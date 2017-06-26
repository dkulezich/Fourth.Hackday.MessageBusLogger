using DbCreator.Model;
using System.Data.Entity;

namespace DbCreator
{
    public class MessageContext : DbContext
    {
        public MessageContext() : base("LoggedBusMessagesConnectionString")
        {

        }

        public DbSet<MessageDetails> MessagesDetails { get; set; }
        public DbSet<MessageContent> MessagesContent { get; set; }
    }
}
