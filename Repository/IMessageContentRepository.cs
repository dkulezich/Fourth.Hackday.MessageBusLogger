using DbCreator.Model;
using System.Collections.Generic;

namespace Repository
{
    public interface IMessageContentRepository<TEntity, in TKey>: IRepository<TEntity, TKey>
    {
        IList<MessageContent> GetByType(string type);
    }
}
