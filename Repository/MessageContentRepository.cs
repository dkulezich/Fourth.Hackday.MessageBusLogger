using System;
using System.Collections.Generic;
using DbCreator.Model;
using System.Linq;
using DbCreator;

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
            dbContext.MessagesContent.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(MessageContent entity)
        {
            dbContext.MessagesContent.Remove(entity);
            dbContext.SaveChanges();
        }

        public IList<MessageContent> GetAll()
        {
            return dbContext.MessagesContent.ToList();
        }

        public MessageContent GetById(long id)
        {
            return dbContext.MessagesContent.Find(id);
        }   
        
        public IList<MessageContent> GetByType(string type)
        {
            var messages = dbContext.MessagesContent.Where(m => m.MessageDetails.Type.Equals(type)).ToList(); 

            return messages;
        }     
    }
}
