using System;
using System.Collections.Generic;
using DbCreator.Model;
using System.Linq;

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
            dbContext.MessageDetails.Add(entity);
        }

        public void Delete(MessageDetails entity)
        {
            dbContext.MessageDetails.Remove(entity);
        }
        
        public MessageDetails GetById(long id)
        {
            return dbContext.MessageDetails.FirstOrDefault(x => x.Id == id);
        }

        public IList<MessageDetails> GetAll()
        {
            return dbContext.MessageDetails.ToList();
        }

        public IList<MessageDetails> GetByDate(DateTime date)
        {
            return dbContext.MessageDetails.Where(x => x.Date == date).ToList();
        }

        public IList<MessageDetails> GetByEnvironment(string environment)
        {
            return dbContext.MessageDetails.Where(x => x.Environment.Equals(environment)).ToList();
        }

        public IList<MessageDetails> GetBySystem(string sourceSystem)
        {
            return dbContext.MessageDetails.Where(x => x.SourceSystem.Equals(sourceSystem)).ToList();
        }

        public IList<MessageDetails> GetByType(string messageType)
        {
            return dbContext.MessageDetails.Where(x => x.Type.Equals(messageType)).ToList();
        }

       
    }
}
