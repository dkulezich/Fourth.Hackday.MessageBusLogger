using DbCreator.Model;
using System.Collections.Generic;

namespace Repository
{
    public interface IMessageRepository
    {
        void Insert(MessageDetails entity);
        void Delete(MessageDetails entity);
        MessageDetails GetById(long id);
        IList<MessageDetails> GetAll();
        IList<MessageDetails> GetByType(string type);
    }
}
