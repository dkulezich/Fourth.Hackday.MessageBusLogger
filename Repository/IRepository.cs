using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        T GetById(int id);
        IList<T> GetAll();
    }
}
