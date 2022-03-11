namespace WebApplication1.Infrastructure
{
    public interface IRepositoryManager
    {
        IRepository<TEntity> Get<TEntity>() where TEntity : class;
        void Save();
    }
}
