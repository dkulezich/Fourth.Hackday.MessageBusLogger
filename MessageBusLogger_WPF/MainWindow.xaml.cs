using DbCreator.Model;
using Fourth.Orchestration.Messaging.Azure;
using Fourth.Orchestration.Storage.Azure;
using Google.ProtocolBuffers;
using MessageBusReceiver;
using Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Xml;
using MahApps.Metro.Controls;

namespace MessageBusLogger_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private const string SUBSCRIPTION_NAME = "MessageBusLogger";
        //private const string SUBSCRIPTION_NAME = "ilian";
        private const string ASSEMBLY_NAME = "Fourth.Orchestration.Model";
        private const string ALL_TYPES = "All types";
        private const string ALL_SYSTEMS = "All systems";

        private string connectionStringCurrentConnected;
        private MessageEventListener messageEventListener;
        private IList<MessageDetails> messages;
        private IMessageRepository repository;
        private Assembly assembly;
        private int selectedMessageIndex;
        private IMessage selectedMessage;

        public MainWindow()
        {
            InitializeComponent();
            repository = new MessageRepository();
            btnDisconnect.Visibility = Visibility.Hidden;
            EnableUi(false);
            LoadMessageTypeComboBox();
            LoadMaxCountValuesComboBox();
            SetDateTimePickerDefaultValues();
            repository = new MessageRepository();
        }

        private void btnSubscribe_Click(object sender, RoutedEventArgs e)
        {
            connectionStringCurrentConnected = txtConnectionStringListener.Text;

            if (!string.IsNullOrEmpty(connectionStringCurrentConnected))
            {
                try
                {
                    ChangeAzureMessageBusConnectionString(connectionStringCurrentConnected);
                    messageEventListener = new MessageEventListener(SUBSCRIPTION_NAME, connectionStringCurrentConnected);
                    var task = Task.Run(() =>
                    {
                        messageEventListener.StartListen();
                    });

                    btnSubscribe.Visibility = Visibility.Hidden;
                    btnDisconnect.Visibility = Visibility.Visible;
                    txtConnectionStringListener.IsEnabled = false;

                    EnableUi(true);
                    LoadSourceSystemComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDisconnect_Click(object sender, RoutedEventArgs e)
        {
            if (messageEventListener != null)
            {
                messageEventListener.StopListen();
            }
            btnSubscribe.Visibility = Visibility.Visible;
            btnDisconnect.Visibility = Visibility.Hidden;
            txtConnectionStringListener.IsEnabled = true;
            gridMessages.ItemsSource = null;
            EnableUi(false);
        }

        private void ChangeAzureMessageBusConnectionString(string connectionString)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            xmlDoc.SelectSingleNode("//orchestrationAzure").Attributes["connectionString"].Value = connectionString;
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("orchestrationAzure");
        }

        private void EnableUi(bool enabled)
        {
            groupFilters.IsEnabled = enabled;
            mainContainer.IsEnabled = enabled;
            txtResendString.IsEnabled = enabled;
            btnResendMessage.IsEnabled = enabled;
            lblResendString.IsEnabled = enabled;
        }
        
        private void btnGetMessages_Click(object sender, RoutedEventArgs e)
        {
            var filter = new Repository.Models.Filter();
            filter.Type = string.Empty;
            filter.SourceSystem = string.Empty;
            filter.MaxCount = int.Parse(cmbMaxCount.SelectionBoxItem.ToString());
            filter.StartDate = pickerStartDate.SelectedDate.Value;
            filter.EndDate = pickerEndDate.SelectedDate.Value.AddDays(1);
            filter.Endpoint = txtConnectionStringListener.Text;

            if (chbShowAll.IsChecked == true)
            {
                filter.Endpoint = string.Empty;
            }

            if (this.cmbMessageType.SelectedItem != null &&
                this.cmbMessageType.SelectedItem.ToString() != ALL_TYPES)
            {
                filter.Type = this.cmbMessageType.SelectedItem.ToString();
                filter.Type = ASSEMBLY_NAME + "." + filter.Type;
            }

            if (cmbSourceSystem.SelectedItem.ToString() != ALL_SYSTEMS)
            {
                filter.SourceSystem = cmbSourceSystem.SelectedItem.ToString();
            }

            messages = repository.FindBy(filter);
            
            gridMessages.ItemsSource = messages.Select(m => new
            {
                DateTime = m.Date,
                Type = m.Type,
                Source = m.SourceSystem,
                Endpoint = m.MessageBusEndpoint,
                TrackingId = m.TrackingId
            }).ToList();
        }

        private void LoadMessageTypeComboBox()
        {
            assembly = Assembly.Load(ASSEMBLY_NAME);
            var myType = typeof(IMessage);
            var types = assembly.ExportedTypes.Where(a => myType.IsAssignableFrom(a)
            && !a.FullName.Contains("+Types")
            && !a.FullName.Contains("Commands+"))
                .OrderBy(a => a.FullName)
                .Select(a => a.FullName.Replace(ASSEMBLY_NAME + ".", "")).ToList();
            types.Insert(0, ALL_TYPES);
            this.cmbMessageType.ItemsSource = types;
            this.cmbMessageType.SelectedIndex = 0;
        }

        private void LoadSourceSystemComboBox()
        {
            var sourceSystemsList = repository.GetAllSourceSystems();
            sourceSystemsList.Insert(0, ALL_SYSTEMS);
            cmbSourceSystem.ItemsSource = sourceSystemsList;
            cmbSourceSystem.SelectedIndex = 0;
        }

        private void LoadMaxCountValuesComboBox()
        {
            cmbMaxCount.SelectedIndex = 3;
        }

        private void SetDateTimePickerDefaultValues()
        {
            pickerStartDate.SelectedDate = DateTime.Today.AddMonths(-1);
            pickerEndDate.SelectedDate = DateTime.Today;
        }

        private void btnResendMessage_Click(object sender, RoutedEventArgs e)
        {
            string messageText = new TextRange(txtMessages.Document.ContentStart, txtMessages.Document.ContentEnd).Text;

            var connectionString = this.txtResendString.Text;
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = connectionStringCurrentConnected;
            }

            try
            {
                ChangeAzureMessageBusConnectionString(connectionString);
                var messageStore = new AzureMessageStore();
                var messageFactory = new AzureMessagingFactory(messageStore);
                var messageBus = messageFactory.CreateMessageBus();
                var result = messageBus.Publish(this.selectedMessage);

                if (result)
                {
                    MessageBox.Show("Successfully resent!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private static IMessage ParseMessage(string messageBase64, Type messageType)
        {
            if (messageBase64 == null) throw new ArgumentNullException("messageBase64");
            // Verify if message type implements IMessage
            if (!typeof(IMessage).IsAssignableFrom(messageType)) throw new ArgumentException("messageType should implement IMessage interface");

            MethodInfo parseMethod = messageType.GetMethod("ParseFrom", new[] { typeof(ByteString) });
            var messageBody = ByteString.FromBase64(messageBase64);
            var message = parseMethod.Invoke(null, new object[] { messageBody }) as IMessage;
            return message;
        }
        
        private void gridMessages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                var dg = sender as DataGrid;
                if (dg == null) return;
                var index = dg.SelectedIndex;

                this.selectedMessageIndex = index;
                txtMessages.Document.Blocks.Clear();

                var type = messages[this.selectedMessageIndex].Type;
                var classType = assembly.GetType(type);
                var message = ParseMessage(messages[this.selectedMessageIndex].MessageContent.Message, classType);
                this.selectedMessage = message;
                this.txtMessages.AppendText($"{message.ToString()}");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
