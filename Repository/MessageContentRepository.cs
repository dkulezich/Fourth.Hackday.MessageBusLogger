using System;
using System.Collections.Generic;
using DbCreator.Model;
using System.Linq;

namespace Repository
{
    public class MessageContentRepository<TEntity, TKey> : IMessageContentRepository<MessageContent, long>
    {
        private readonly MessageContext dbContext;

        public MessageContentRepository(MessageContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Insert(MessageContent entity)
        {
            dbContext.MessageContent.Add(entity);
        }

        public void Delete(MessageContent entity)
        {
            dbContext.MessageContent.Remove(entity);
        }

        public IList<MessageContent> GetAll()
        {
            return dbContext.MessageContent.ToList();
        }

        public MessageContent GetById(long id)
        {
            return dbContext.MessageContent.FirstOrDefault(x => x.Id == id);
        }

        
    }
}
