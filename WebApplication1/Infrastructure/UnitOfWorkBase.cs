using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Infrastructure
{
    public abstract class UnitOfWorkBase<TDbContext> : IUnitOfWorkBase where TDbContext : DbContext
    {
        protected readonly TDbContext _context;

        protected UnitOfWorkBase(TDbContext context)
        {
            _context = context;
        }

        public void Save() => _context.SaveChanges();
    }
}
