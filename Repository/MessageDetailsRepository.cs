using System;
using System.Collections.Generic;
using DbCreator.Model;
using System.Linq;
using DbCreator;

namespace Repository
{
    public class MessageDetailsRepository<TEntity, TKey> : IMessageDetailsRepository<MessageDetails, long>
    {
        private readonly MessageContext dbContext;

        public MessageDetailsRepository(MessageContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Insert(MessageDetails entity)
        {
            dbContext.MessagesDetails.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(MessageDetails entity)
        {
            dbContext.MessagesDetails.Remove(entity);
            dbContext.SaveChanges();
        }
        
        public MessageDetails GetById(long id)
        {
            return dbContext.MessagesDetails.Find(id);
        }

        public IList<MessageDetails> GetAll()
        {
            return dbContext.MessagesDetails.ToList();
        }

        public IList<MessageDetails> GetByDate(DateTime date)
        {
            return dbContext.MessagesDetails.Where(x => x.Date == date).ToList();
        }

        public IList<MessageDetails> GetByEnvironment(string environment)
        {
            return dbContext.MessagesDetails.Where(x => x.Environment.Equals(environment)).ToList();
        }

        public IList<MessageDetails> GetBySystem(string sourceSystem)
        {
            return dbContext.MessagesDetails.Where(x => x.SourceSystem.Equals(sourceSystem)).ToList();
        }

        public IList<MessageDetails> GetByType(string messageType)
        {
            return dbContext.MessagesDetails.Where(x => x.Type.Equals(messageType)).ToList();
        }       
    }
}
