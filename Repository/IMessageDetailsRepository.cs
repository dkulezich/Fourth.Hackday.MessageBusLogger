using DbCreator.Model;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IMessageDetailsRepository<TEntity, in TKey> : IRepository<MessageDetails, TKey>
    {
        IList<MessageDetails> GetByType(string messageType);
        IList<MessageDetails> GetBySystem(string sourceSystem);
        IList<MessageDetails> GetByEnvironment(string environment);
        IList<MessageDetails> GetByDate(DateTime date);
    }
}
