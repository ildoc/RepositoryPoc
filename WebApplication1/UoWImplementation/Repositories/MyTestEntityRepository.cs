using WebApplication1.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.UoWImplementation.Repositories
{
    public class MyTestEntityRepository : RepositoryBase<MyTestEntity>, IMyTestEntityRepository
    {
        public MyTestEntityRepository(MyDbContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<MyTestEntity> GetAllMyTestEntities(bool trackChanges) =>
           FindAll(trackChanges)
           .OrderBy(c => c.Name)
           .ToList();
    }
}
