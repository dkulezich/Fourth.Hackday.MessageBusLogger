﻿using Fourth.Orchestration.Messaging;
using Fourth.Orchestration.Messaging.Azure;
using Fourth.Orchestration.Storage;
using Fourth.Orchestration.Storage.Azure;
using Fourth.Orchestration.Model.ProductCatalogue;
using System.Reflection;
using System.Linq;
using Google.ProtocolBuffers;
using System;

namespace MessageBusReceiver
{
    public class MessageEventListener
    {
        private IMessageStore messageStore;
        private IMessagingFactory messageFactory;
        private IMessageListener messageListener;
        private const string ASSEMBLY_NAME = "Fourth.Orchestration.Model";

        public MessageEventListener(string subscription)
        {
            messageStore = new AzureMessageStore();
            messageFactory = new AzureMessagingFactory(messageStore);
            messageListener = messageFactory.CreateMessageListener(subscription);
        }

        public void StartListen()
        {
            var assembly = Assembly.Load(ASSEMBLY_NAME);
            var messageType = typeof(Google.ProtocolBuffers.IMessage);
            var types = assembly.ExportedTypes.Where(a => messageType.IsAssignableFrom(a))
                .OrderBy(a => a.FullName)
                .Select(a => a.FullName).ToList();

            Type classType = assembly.GetType(types[121]);

            var type = typeof(MessageHandler<>).MakeGenericType(new[] { classType });
            messageListener.RegisterHandler(Activator.CreateInstance(type) as IMessageHandler);
            messageListener.StartListener();
        }

        public void StopListen()
        {
            messageListener.StopListener();
            messageListener.Dispose();
        }

        public IMessage ParseMessage(string messageBase64, Type messageType)
        {
            MethodInfo parseMethod = messageType.GetMethod("ParseFrom", new[] { typeof(ByteString) });
            var messageBody = ByteString.FromBase64(messageBase64);
            var message = parseMethod.Invoke(null, new object[] { messageBody }) as IMessage;

            return message;
        }
    }
}
