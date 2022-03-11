using WebApplication1.Models;

namespace WebApplication1.RepoImplementation.Repositories
{
    public interface IMyTestEntityRepository
    {
        IEnumerable<MyTestEntity> GetAllMyTestEntities(bool trackChanges);
    }
}
