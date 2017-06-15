using Microsoft.Azure;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBusLogger
{
    public partial class MessageBusLogger : Form
    {
        private const string SUBSCRIPTION_NAME = "messageBusLogger";

        private string connectionString = CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");
        private NamespaceManager namespaceManager;

        public MessageBusLogger()
        {
            InitializeComponent();
            namespaceManager = NamespaceManager.CreateFromConnectionString(connectionString);
        }

        private async void subscrBtn_Click(object sender, EventArgs e)
        {
            var topicList = await namespaceManager.GetTopicsAsync();

            foreach (TopicDescription topic in topicList)
            {
                if(!namespaceManager.SubscriptionExists(topic.Path, SUBSCRIPTION_NAME))
                {
                    await namespaceManager.CreateSubscriptionAsync(topic.Path, SUBSCRIPTION_NAME);
                }
                
            }
        }
    }
}
