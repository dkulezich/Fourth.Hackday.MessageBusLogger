using DbCreator;
using DbCreator.Model;
using Fourth.Orchestration.Messaging;
using Google.ProtocolBuffers;
using Newtonsoft.Json.Linq;
using Repository;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MessageBusReceiver
{
    public class MessageHandler<T> : IMessageHandler<T> where T : IMessage
    {
        private string endpoint;
        MessageContent messageContent = new MessageContent();
        MessageRepository messageContentRepository = new MessageRepository();

        public MessageHandler(string endpoint)
        {
            this.endpoint = endpoint;
        }

        public Task<MessageHandlerResult> HandleAsync(T payload, string trackingId)
        {
            try
            {
                var jObject = JObject.Parse(payload.ToJson());
                var jToken = jObject.SelectToken("$.Source");

                var messageDetails = new MessageDetails();
                messageDetails.Date = DateTime.UtcNow;
                messageDetails.MessageBusEndpoint = this.endpoint;
                messageDetails.Type = payload.GetType().FullName;
                messageDetails.TrackingId = trackingId;
                messageDetails.SourceSystem = jToken.ToString();
                messageContent.Message = payload.ToByteString().ToBase64();
                messageDetails.MessageContent = messageContent;
                messageContentRepository.Insert(messageDetails);
            }
            catch (Exception ex)
            {
                return Task.FromResult<MessageHandlerResult>(MessageHandlerResult.Fatal);
            }

            return Task.FromResult<MessageHandlerResult>(MessageHandlerResult.Success);
        }        
    }
}
