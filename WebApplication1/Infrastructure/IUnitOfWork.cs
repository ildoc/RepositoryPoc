namespace WebApplication1.Infrastructure
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> Get<TEntity>() where TEntity : class;
        void Save();
    }
}
