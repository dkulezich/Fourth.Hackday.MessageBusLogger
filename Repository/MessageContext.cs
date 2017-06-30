using DbCreator.Model;
using System.Data.Entity;

namespace Repository
{
    public class MessageContext : DbContext
    {
        public IDbSet<MessageDetails> MessageDetails { get; set; }
        public IDbSet<MessageContent> MessageContent { get; set; }
    }
}
