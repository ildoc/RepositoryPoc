using WebApplication1.Infrastructure;
using WebApplication1.UoWImplementation.Repositories;

namespace WebApplication1.UoWImplementation
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
        IMyTestEntityRepository MyTestEntity { get; }
    }
}
