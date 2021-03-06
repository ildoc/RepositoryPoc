using System.Linq.Expressions;

namespace WebApplication1.Infrastructure
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges);

        Task<T> GetByIdAsync<TId>(TId id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
