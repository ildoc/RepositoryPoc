using WebApplication1.Models;

namespace WebApplication1.UoWImplementation.Repositories
{
    public interface IMyTestEntityRepository
    {
        IEnumerable<MyTestEntity> GetAllMyTestEntities(bool trackChanges);
    }
}
