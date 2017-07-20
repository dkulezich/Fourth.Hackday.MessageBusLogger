using DbCreator;
using DbCreator.Model;
using Fourth.Orchestration.Messaging.Azure;
using Fourth.Orchestration.Storage.Azure;
using Google.ProtocolBuffers;
using MessageBusReceiver;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using Fourth.Orchestration.Model.ProductCatalogue;
using System.Text;

namespace MessageBusLogger
{
    public partial class MessageBusLogger : Form
    {
        //private const string SUBSCRIPTION_NAME = "MessageBusLogger";
        private const string SUBSCRIPTION_NAME = "ilian";
        private const string ASSEMBLY_NAME = "Fourth.Orchestration.Model";
        private const string ALL_TYPES = "All types";
        private const string ALL_SYSTEMS = "All systems";
        

        private IMessageRepository repository;
        private IList<MessageDetails> messages;
        private int selectedMessageIndex;
        private IMessage selectedMessage;
        private Assembly assembly;
        private string connectionStringCurrentConnected;        
        private MessageEventListener messageEventListener;

        public MessageBusLogger()
        {            
            InitializeComponent();
            btnDisconnect.Hide();
            EnableUi(false);
            LoadMessageTypeComboBox();
            LoadMaxCountValuesComboBox();
            SetDateTimePickerDefaultValues();
            repository = new MessageRepository();            
        }

        private void btnSubscr_Click(object sender, EventArgs e)
        {
            connectionStringCurrentConnected = this.txtConnectionStringListener.Text;

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

                    btnSubscr.Hide();
                    btnDisconnect.Show();
                    txtConnectionStringListener.Enabled = false;

                    EnableUi(true);
                    LoadSourceSystemComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            messageEventListener.StopListen();
            btnSubscr.Show();
            btnDisconnect.Hide();
            txtConnectionStringListener.Enabled = true;
            gridMessages.DataSource = null;
            EnableUi(false);
        }

        private void gridMessages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedMessageIndex = e.RowIndex;
            this.txtMessages.Clear();

            var type = messages[this.selectedMessageIndex].Type;
            var classType = assembly.GetType(type);
            var message = ParseMessage(messages[this.selectedMessageIndex].MessageContent.Message, classType);
            this.selectedMessage = message;
            //this.txtMessages.AppendText($"{this.selectedMessageIndex + 1} {new string('-', 50)}\r\n");
            //this.txtMessages.AppendText($"Type: {type.Replace(ASSEMBLY_NAME + ".", "")}\r\n");
            //this.txtMessages.AppendText($"DateTime: {messages[this.selectedMessageIndex].Date}\r\n");
            this.txtMessages.AppendText($"{message.ToString()}");
        }

        private void EnableUi(bool enabled)
        {
            groupFilters.Enabled = enabled;
            mainContainer.Enabled = enabled;
            txtResendString.Enabled = enabled;
            btnResendMessage.Enabled = enabled;
            label2.Enabled = enabled;
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
            this.cmbMessageType.DataSource = types;
            this.cmbMessageType.SelectedIndex = 0;
        }

        private void LoadSourceSystemComboBox()
        {
            var sourceSystemsList = repository.GetAllSourceSystems();
            sourceSystemsList.Insert(0, ALL_SYSTEMS);
            cmbSourceSystem.DataSource = sourceSystemsList;
            cmbSourceSystem.SelectedIndex = 0;
        }

        private void LoadMaxCountValuesComboBox()
        {
            cmbMaxCount.SelectedIndex = 3;
        }

        private void SetDateTimePickerDefaultValues()
        {
            pickerStartDate.Value = DateTime.Today.AddMonths(-1);
            pickerEndDate.Value = DateTime.Today;
        }
        
        private void btnGetMessages_Click(object sender, EventArgs e)
        {
            var filter = new Repository.Models.Filter();
            filter.Type = string.Empty;
            filter.SourceSystem = string.Empty;
            filter.MaxCount = int.Parse(cmbMaxCount.SelectedItem.ToString());
            filter.StartDate = pickerStartDate.Value;
            filter.EndDate = pickerEndDate.Value.AddDays(1);
            filter.Endpoint = txtConnectionStringListener.Text;

            if (chbShowAll.Checked)
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

            gridMessages.DataSource = messages.Select(m => new
            {
                DateTime = m.Date,
                Type = m.Type,
                Source = m.SourceSystem,
                Endpoint = m.MessageBusEndpoint,
                TrackingId = m.TrackingId    
            }).ToList();
        }

        private void BtnResendMessage_Click(object sender, EventArgs e)
        {
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
                //ChangeSequenceNumber(this.selectedMessage);
                //var type = messages[this.selectedMessageIndex].Type;
                //var classType = assembly.GetType(type);
                //byte[] toBytes = Encoding.ASCII.GetBytes(this.txtMessages.Text);
                //var a = ByteString.CopyFrom(toBytes).ToBase64();
                //var mes = ParseMessage(a, classType); 
                var result = messageBus.Publish(this.selectedMessage);

                if (result)
                {
                    MessageBox.Show("Successfully resent!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeSequenceNumber(IMessage selectedMessage)
        {
            var type = messages[this.selectedMessageIndex].Type;
            var classType = assembly.GetType(type);
            var message = ParseMessage(messages[this.selectedMessageIndex].MessageContent.Message, classType);
            Events.ProductLocationsModified a = Fourth.Orchestration.Model.ProductCatalogue.Events.ProductLocationsModified.ParseFrom(message.ToByteString());
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.HighlightWords(new string[] { this.txtFind.Text });
        }
        
        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.HighlightWords(new string[] { this.txtFind.Text });
            }
        }

        private void HighlightWords(string[] words)
        {
            this.txtMessages.SelectionStart = 0;
            this.txtMessages.SelectionLength = this.txtMessages.Text.Length;
            this.txtMessages.SelectionBackColor = Color.WhiteSmoke;

            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < this.txtMessages.TextLength)
                {
                    int wordStartIndex = this.txtMessages.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        this.txtMessages.SelectionStart = wordStartIndex;
                        this.txtMessages.SelectionLength = word.Length;
                        this.txtMessages.SelectionBackColor = Color.Yellow;
                    }
                    else
                    {
                        break;
                    }

                    startIndex += wordStartIndex + word.Length;
                }
            }
        }
        
        private void ChangeAzureMessageBusConnectionString(string connectionString)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            xmlDoc.SelectSingleNode("//orchestrationAzure").Attributes["connectionString"].Value = connectionString;
            //"Endpoint=sb://rntestorchestration.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=o4SfS9q+vyffUM10ydy+ccN3Av94GZiNVV2/dyep3j0=";
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("orchestrationAzure");
        }
        
    }
}
