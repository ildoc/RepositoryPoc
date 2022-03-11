using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public virtual IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
              _context.Set<T>()
                .AsNoTracking() :
              _context.Set<T>();

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges) =>
            !trackChanges ?
              _context.Set<T>()
                .Where(expression)
                .AsNoTracking() :
              _context.Set<T>()
                .Where(expression);

        public virtual Task<T> GetByIdAsync<TId>(TId id) =>
            _context.Set<T>().FindAsync(id).AsTask();

        public virtual void Create(T entity) => _context.Set<T>().Add(entity);

        public virtual void Update(T entity) => _context.Set<T>().Update(entity);

        public virtual void Delete(T entity) => _context.Set<T>().Remove(entity);
    }
}
