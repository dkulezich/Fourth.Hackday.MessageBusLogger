using DbCreator;
using DbCreator.Model;
using Fourth.Orchestration.Messaging;
using Google.ProtocolBuffers;
using Repository;
using System;
using System.Threading.Tasks;

namespace MessageBusReceiver
{
    public class MessageHandler<T> : IMessageHandler<T> where T : IMessage
    {
        private string environment;
        public string Environment { set { environment = value; } }

        MessageContent messageContent = new MessageContent();
        MessageContentRepository<MessageContent, long> messageContentRepository = new MessageContentRepository<MessageContent, long>(new MessageContext());


        public Task<MessageHandlerResult> HandleAsync(T payload, string trackingId)
        {
            var messageDetails = new MessageDetails();
            messageDetails.Date = DateTime.UtcNow;
            messageDetails.Environment = environment;
            messageDetails.Type = payload.GetType().FullName;
            messageDetails.TrackingId = trackingId;
            messageContent.Message = payload.ToByteString().ToBase64();
            messageContent.MessageDetails = messageDetails;
            messageContentRepository.Insert(messageContent);

            return Task.FromResult<MessageHandlerResult>(MessageHandlerResult.Success);
        }
    }
}
