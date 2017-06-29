using System;

namespace Repository
{
    public interface IMessageDetailsRepository<T> : IRepository<T>
    {
        T GetByType(string messageType);
        T GetBySystem(string sourceSystem);
        T GetByEnvironment(string environment);
        T GetByDate(DateTime date);
    }
}
