using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Infrastructure
{
    public class RepositoryManagerBase<TDbContext> : IRepositoryManagerBase where TDbContext : DbContext
    {
        protected readonly TDbContext _context;

        public RepositoryManagerBase(TDbContext context)
        {
            _context = context;
        }

        public void Save() => _context.SaveChanges();
    }
}
