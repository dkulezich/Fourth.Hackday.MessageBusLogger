using System;
using System.Collections.Generic;
using DbCreator.Model;
using System.Linq;
using DbCreator;
using System.Data.Entity;
using Repository.Models;

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

        public IList<MessageDetails> FindBy(Filter filter)
        {
            var messages = new List<MessageDetails>();

            using (var dbContext = new MessageContext())
            {
                var query = dbContext.MessagesDetails.AsQueryable();


                 query = query.Where(c => c.Date >= filter.StartDate);

                 query = query.Where(c => c.Date <= filter.EndDate);

                if (!string.IsNullOrEmpty(filter.Type))
                {
                    query = query.Where(m => m.Type.Equals(filter.Type));
                }

                if (!string.IsNullOrEmpty(filter.SourceSystem))
                {
                    query = query.Where(m => m.SourceSystem.Equals(filter.SourceSystem));
                }

                if (!string.IsNullOrEmpty(filter.Endpoint))
                {
                    query = query.Where(m => m.MessageBusEndpoint.Equals(filter.Endpoint));
                }

                messages = query.OrderByDescending(x => x.Date).Take(filter.MaxCount)
                        .Include(m => m.MessageContent).ToList();
            }

            return messages;
        }

        public IList<string> GetAllSourceSystems()
        {
            var messages = new List<string>();

            using (var dbContext = new MessageContext())
            {
                //messages = dbContext.MessagesDetails.Select(x => x.SourceSystem).Distinct().ToList();
                messages = dbContext.MessagesDetails.GroupBy(m => m.SourceSystem).Select(m => m.Key).ToList();
            }

            return messages;
        }
    }
}
