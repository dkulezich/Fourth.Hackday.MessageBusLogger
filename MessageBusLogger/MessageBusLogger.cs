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
        private SubscriptionClient Client;

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

                //TopicClient ClientTopic = TopicClient.CreateFromConnectionString(connectionString, topic.Path);

                //for (int i = 0; i < 5; i++)
                //{
                //    // Create message, passing a string message for the body.
                //    BrokeredMessage message = new BrokeredMessage("Test message " + i);

                //    // Set additional custom app-specific property.
                //    message.Properties["MessageId"] = i;

                //    // Send message to the topic.
                //    ClientTopic.Send(message);
                //}


                Client = SubscriptionClient.CreateFromConnectionString(connectionString, topic.Path, SUBSCRIPTION_NAME);

                // Configure the callback options.
                OnMessageOptions options = new OnMessageOptions();
                options.AutoComplete = false;
                options.AutoRenewTimeout = TimeSpan.FromMinutes(1);

                Client.OnMessage((message) =>
                {
                    try
                    {
                        using (System.IO.TextWriter file = new System.IO.StreamWriter("test_mb.txt", true))
                        {
                            file.WriteLine("------------------START------------------");
                            file.WriteLine("Topic Name: " + topic.Path);
                            file.WriteLine("Body: " + message.GetBody<string>());
                            file.WriteLine("MessageID: " + message.MessageId);
                            file.WriteLine("Message Number: " + message.Properties["MessageNumber"]);
                            file.WriteLine("------------------END------------------");


                            // Remove message from subscription.
                            message.Complete();
                        }

                    }
                    catch (Exception)
                    {                        
                        // Indicates a problem, unlock message in subscription.
                        message.Abandon();
                    }

                }, options);

            }
        }
    }
}
