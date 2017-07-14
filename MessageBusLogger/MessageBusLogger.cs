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
        private const string SUBSCRIPTION_NAME = "MessageBusLogger";
        private const string ASSEMBLY_NAME = "Fourth.Orchestration.Model";
        private const string ALL_TYPES = "All types";

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
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            connectionStringCurrentConnected = this.txt_ConnectionStringListener.Text;

            if (!string.IsNullOrEmpty(connectionStringCurrentConnected))
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                xmlDoc.SelectSingleNode("//orchestrationAzure").Attributes["connectionString"].Value = connectionStringCurrentConnected;
                //"Endpoint=sb://rntestorchestration.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=o4SfS9q+vyffUM10ydy+ccN3Av94GZiNVV2/dyep3j0=";
                xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                ConfigurationManager.RefreshSection("orchestrationAzure");
            }
            
            var messageEventListener = new MessageEventListener(SUBSCRIPTION_NAME, connectionStringCurrentConnected);
            messageEventListener.StartListen();

        }

        private void gridMessages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var i = e.RowIndex;
            this.txtMessages.Clear();

            var type = messages[i].Type;
            var classType = assembly.GetType(type);
            var message = ParseMessage(messages[i].MessageContent.Message, classType);
            this.selectedMessage = message;
            this.txtMessages.AppendText($"{i + 1} {new string('-', 50)}\n");
            this.txtMessages.AppendText($"Type: {type.Replace(ASSEMBLY_NAME + ".", "")}\n");
            this.txtMessages.AppendText($"DateTime: {messages[i].Date}\n\n");
            this.txtMessages.AppendText($"{message}\n");
        }


        private void LoadMessageTypeComboBox()
        {
            assembly = Assembly.Load(ASSEMBLY_NAME);
            var myType = typeof(IMessage);
            var types = assembly.ExportedTypes.Where(a => myType.IsAssignableFrom(a))
                .OrderBy(a => a.FullName)
                .Select(a => a.FullName.Replace(ASSEMBLY_NAME + ".", "")).ToList();
            types.Insert(0, ALL_TYPES);
            this.cmbMessageType.DataSource = types;
            this.cmbMessageType.SelectedIndex = 0;
        }

        private void SourceSystemComboBox()
        {
            
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

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            xmlDoc.SelectSingleNode("//orchestrationAzure").Attributes["connectionString"].Value = connectionString;
            //"Endpoint=sb://rntestorchestration.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=o4SfS9q+vyffUM10ydy+ccN3Av94GZiNVV2/dyep3j0=";
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("orchestrationAzure");

            var messageStore = new AzureMessageStore();
            var messageFactory = new AzureMessagingFactory(messageStore);
            var messageBus = messageFactory.CreateMessageBus();

            //var type = messages[0].Type;
            //var classType = assembly.GetType(type);
            //var message = ParseMessage(messages[0].MessageContent.Message, classType);

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
    }
}
