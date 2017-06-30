namespace Repository
{
    public interface IMessageContentRepository<TEntity, in TKey>: IRepository<TEntity, TKey>
    {
    }
}
