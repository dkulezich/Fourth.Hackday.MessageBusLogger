using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<TEntity, in TKey>
    {
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(TKey id);
        IList<TEntity> GetAll();
    }
}
