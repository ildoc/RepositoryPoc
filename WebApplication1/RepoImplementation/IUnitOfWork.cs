using WebApplication1.Infrastructure;
using WebApplication1.RepoImplementation.Repositories;

namespace WebApplication1.RepoImplementation
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
        IMyTestEntityRepository MyTestEntity { get; }
    }
}
