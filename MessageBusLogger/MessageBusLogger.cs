using DbCreator;
using DbCreator.Model;
using Fourth.Orchestration.Messaging.Azure;
using Fourth.Orchestration.Storage.Azure;
using Google.ProtocolBuffers;
using MessageBusReceiver;
using Microsoft.Azure;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

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
        private IMessage selectedMessage;
        private Assembly assembly;
        private string connectionStringCurrentConnected;

        public MessageBusLogger()
        {
            InitializeComponent();
            LoadMessageTypeComboBox();
            repository = new MessageRepository();
            LoadSourceSystemComboBox();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            connectionStringCurrentConnected = this.txt_ConnectionStringListener.Text;

            if (!string.IsNullOrEmpty(connectionStringCurrentConnected))
            {
                try
                {
                    ChangeAzureMessageBusConnectionString(connectionStringCurrentConnected);
                    var messageEventListener = new MessageEventListener(SUBSCRIPTION_NAME, connectionStringCurrentConnected);
                    var task = Task.Run(() =>
                    {
                        messageEventListener.StartListen();                        
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gridMessages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var i = e.RowIndex;
            this.txtMessages.Clear();

            var type = messages[i].Type;
            var classType = assembly.GetType(type);
            var message = ParseMessage(messages[i].MessageContent.Message, classType);
            this.selectedMessage = message;
            this.txtMessages.AppendText($"{i + 1} {new string('-', 50)}\r\n");
            this.txtMessages.AppendText($"Type: {type.Replace(ASSEMBLY_NAME + ".", "")}\r\n");
            this.txtMessages.AppendText($"DateTime: {messages[i].Date}\r\n");
            this.txtMessages.AppendText($"{message.ToString()}\r\n");
        }


        private void LoadMessageTypeComboBox()
        {
            assembly = Assembly.Load(ASSEMBLY_NAME);
            var myType = typeof(IMessage);
            var types = assembly.ExportedTypes.Where(a => myType.IsAssignableFrom(a)
            && !a.FullName.Contains("+Types"))
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

        private void btnGetMessages_Click(object sender, EventArgs e)
        {
            var type = ALL_TYPES;

            if (this.cmbMessageType.SelectedItem != null && this.cmbMessageType.SelectedItem.ToString() != ALL_TYPES)
            {
                type = this.cmbMessageType.SelectedItem.ToString();
                type = ASSEMBLY_NAME + "." + type;
                messages = repository.GetByType(type);
            }
            else
            {
                this.cmbMessageType.SelectedItem = ALL_TYPES;
                messages = repository.GetAll();
            }
            
            gridMessages.DataSource = messages.Select(m => new
            {
                TrackingId = m.TrackingId,
                Source = m.SourceSystem,
                DateTime = m.Date,
                Type = m.Type,
                Environment = m.Environment
            }).ToList();
        }

        private void BtnResendMessage_Click(object sender, EventArgs e)
        {
            var connectionString = this.txt_ResendString.Text;
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = connectionStringCurrentConnected;
            }

            ChangeAzureMessageBusConnectionString(connectionString);
            var messageStore = new AzureMessageStore();
            var messageFactory = new AzureMessagingFactory(messageStore);
            var messageBus = messageFactory.CreateMessageBus();

            messageBus.Publish(this.selectedMessage);
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

        private void btn_Find_Click(object sender, EventArgs e)
        {
            this.HighlightWords(new string[] { this.txt_Find.Text });
        }
        
        private void txt_Find_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.HighlightWords(new string[] { this.txt_Find.Text });
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
