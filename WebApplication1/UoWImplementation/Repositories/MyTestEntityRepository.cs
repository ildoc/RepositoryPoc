using WebApplication1.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.UoWImplementation.Repositories
{
    public class MyTestEntityRepository : Repository<MyTestEntity>
    {
        private readonly ILogger<MyTestEntityRepository> _logger;

        public MyTestEntityRepository(MyDbContext repositoryContext, ILogger<MyTestEntityRepository> logger)
            : base(repositoryContext)
        {
            _logger = logger;
        }

        public override IQueryable<MyTestEntity> FindAll(bool trackChanges)
        {
            _logger.LogInformation("ciaone");
            return base.FindAll(trackChanges);
        }
    }
}
