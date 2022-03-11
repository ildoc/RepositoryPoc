using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Infrastructure
{
    public class RepositoryManager<TDbContext> : IDisposable,IRepositoryManager where TDbContext : DbContext
    {
        protected readonly TDbContext _context;
        private readonly IServiceScope _scope;
        private readonly Dictionary<Type, IRepository> _repositories = new();

        public RepositoryManager(TDbContext context, IServiceScopeFactory scopeFactory)
        {
            _context = context;
            _scope = scopeFactory.CreateScope();
        }

        public void Save() => _context.SaveChanges();

        public IRepository<TEntity> Get<TEntity>() where TEntity : class
        {
            var type = typeof(TEntity);
            IRepository<TEntity> value;

            if (_repositories.ContainsKey(type))
            {
                value = (IRepository<TEntity>)_repositories[type];
            }
            else
            {
                value=_scope.ServiceProvider.GetService<IRepository<TEntity>>();
                _repositories.Add(type, value);
            }
            return value;
        }

        public void Dispose()
        {
            _scope?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
