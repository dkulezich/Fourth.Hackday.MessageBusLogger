using Fourth.Orchestration.Messaging;
using Fourth.Orchestration.Messaging.Azure;
using Fourth.Orchestration.Storage;
using Fourth.Orchestration.Storage.Azure;
using Fourth.Orchestration.Model.ProductCatalogue;
using System.Reflection;
using System.Linq;
using Google.ProtocolBuffers;
using System;
using System.Collections.Generic;

namespace MessageBusReceiver
{
    public class MessageEventListener
    {
        private IMessageStore messageStore;
        private IMessagingFactory messageFactory;
        private IMessageListener messageListener;
        private const string ASSEMBLY_NAME = "Fourth.Orchestration.Model";
        private string connectionString;

        public MessageEventListener(string subscription, string connectionString)
        {
            messageStore = new AzureMessageStore();
            messageFactory = new AzureMessagingFactory(messageStore);
            messageListener = messageFactory.CreateMessageListener(subscription);
            this.connectionString = connectionString;
        }

        public void StartListen()
        {
            var assembly = Assembly.Load(ASSEMBLY_NAME);
            var messageType = typeof(Google.ProtocolBuffers.IMessage);
            var types = assembly.ExportedTypes.Where(a => messageType.IsAssignableFrom(a))
                .OrderBy(a => a.FullName)
                .Select(a => a.FullName).ToList();

            var handlers = new List<IMessageHandler>();

            for (int i = 0; i < types.Count; i++)
            {
                //TODO: remove this "if" to subscribe every topic
                //if(i == 103 || i == 121)
                //{
                    Type classType = assembly.GetType(types[i]);
                    var type = typeof(MessageHandler<>).MakeGenericType(new[] { classType });
                    var handler = Activator.CreateInstance(type, this.connectionString) as IMessageHandler;
                    handlers.Add(handler);
                //}
            }

            messageListener.RegisterHandlers(handlers.ToArray());
            messageListener.StartListener();
        }

        public void StopListen()
        {
            messageListener.StopListener();
            messageListener.Dispose();
        }
    }
}
