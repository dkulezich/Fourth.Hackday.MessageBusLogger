using Fourth.Orchestration.Messaging;
using Google.ProtocolBuffers;
using System.Threading.Tasks;

namespace MessageBusReceiver
{
    public class MessageHandler<T> : IMessageHandler<T> where T : IMessage
    {
        public Task<MessageHandlerResult> HandleAsync(T payload, string trackingId)
        {
            return Task.FromResult<MessageHandlerResult>(MessageHandlerResult.Success);
        }
    }
}
