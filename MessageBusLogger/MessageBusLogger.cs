using DbCreator;
using DbCreator.Model;
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

namespace MessageBusLogger
{
    public partial class MessageBusLogger : Form
    {
        private const string SUBSCRIPTION_NAME = "ilian";
        private const string ASSEMBLY_NAME = "Fourth.Orchestration.Model";
        private const string ALL_TYPES = "All types";

        private IMessageContentRepository<MessageContent, long> repository;
        private IList<MessageContent> messages;
        private Assembly assembly;

        public MessageBusLogger()
        {
            InitializeComponent();
            LoadMessageTypeComboBox();
            repository = new MessageContentRepository<MessageContent, long>(new MessageContext());
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            //var messageEventListener = new MessageEventListener(SUBSCRIPTION_NAME);
            //messageEventListener.StartListen();

        }

        private void gridMessages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var i = e.RowIndex;
            this.txtMessages.Clear();

            var type = messages[i].MessageDetails.Type;
            var classType = assembly.GetType(type);
            var message = ParseMessage(messages[i].Message, classType);
            this.txtMessages.AppendText($"{i + 1} {new string('-', 50)}\n");
            this.txtMessages.AppendText($"Type: {type.Replace(ASSEMBLY_NAME + ".", "")}\n");
            this.txtMessages.AppendText($"DateTime: {messages[i].MessageDetails.Date}\n\n");
            this.txtMessages.AppendText($"{message}\n");
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

        private void btnGetMessages_Click(object sender, EventArgs e)
        {
            var type = ALL_TYPES;

            if (this.cmbMessageType.SelectedItem != null && this.cmbMessageType.SelectedItem != ALL_TYPES)
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
                TrackingId = m.MessageDetails.TrackingId,
                Source = m.MessageDetails.SourceSystem,
                DateTime = m.MessageDetails.Date,
                Type = m.MessageDetails.Type
            }).ToList();
        }
    }
}
