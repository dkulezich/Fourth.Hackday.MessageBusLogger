using DbCreator.Model;
using Repository.Models;
using System;
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
        IList<MessageDetails> FindBy(Filter filter);
        IList<string> GetAllSourceSystems();
    }
}
