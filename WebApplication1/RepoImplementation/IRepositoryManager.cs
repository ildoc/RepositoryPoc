using WebApplication1.Infrastructure;
using WebApplication1.RepoImplementation.Repositories;

namespace WebApplication1.RepoImplementation
{
    public interface IRepositoryManager : IRepositoryManagerBase
    {
        IMyTestEntityRepository MyTestEntity { get; }
    }
}
