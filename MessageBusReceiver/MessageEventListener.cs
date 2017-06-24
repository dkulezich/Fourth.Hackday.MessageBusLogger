using Fourth.Orchestration.Messaging;
using Fourth.Orchestration.Messaging.Azure;
using Fourth.Orchestration.Storage;
using Fourth.Orchestration.Storage.Azure;
using Fourth.Orchestration.Model.ProductCatalogue;

namespace MessageBusReceiver
{
    public class MessageEventListener
    {
        private IMessageStore messageStore;
        private IMessagingFactory messageFactory;
        private IMessageListener messageListener;

        public MessageEventListener(string subscription)
        {
            messageStore = new AzureMessageStore();
            messageFactory = new AzureMessagingFactory(messageStore);
            messageListener = messageFactory.CreateMessageListener("Message Bus Logger");
        }

        public void StartListen()
        {
            messageListener.RegisterHandler(new MessageHandler<Events.ProductLocationsModified>());
            messageListener.StartListener();
        }

        public void StopListen()
        {
            messageListener.StopListener();
            messageListener.Dispose();
        }
    }
}
