using System;
using System.Collections.Generic;
using DbCreator.Model;
using System.Linq;
using DbCreator;
using System.Data.Entity;

namespace Repository
{
    public class MessageRepository : IMessageRepository
    { 
        public void Insert(MessageDetails entity)
        {
            using (var dbContext = new MessageContext())
            {
                dbContext.MessagesDetails.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(MessageDetails entity)
        {
            using (var dbContext = new MessageContext())
            {
                dbContext.MessagesDetails.Remove(entity);
                dbContext.SaveChanges();
            }
        }

        public IList<MessageDetails> GetAll()
        {
            var messages = new List<MessageDetails>();

            using (var dbContext = new MessageContext())
            {
                messages = dbContext.MessagesDetails.Include(m => m.MessageContent).ToList();
            }

            return messages;
        }

        public MessageDetails GetById(long id)
        {
            var messageContent = new MessageDetails();
            using (var dbContext = new MessageContext())
            {
                messageContent = dbContext.MessagesDetails.Include(m => m.MessageContent).FirstOrDefault(m => m.Id == id);
            }

            return messageContent;
        }   
        
        public IList<MessageDetails> GetByType(string type)
        {
            var messages = new List<MessageDetails>();

            using (var dbContext = new MessageContext())
            {
                messages = dbContext.MessagesDetails.Where(m => m.Type.Equals(type)).Include(m => m.MessageContent).ToList();
            }

            return messages;
        }     
    }
}
