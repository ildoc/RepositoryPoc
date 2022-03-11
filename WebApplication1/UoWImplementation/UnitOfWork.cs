using WebApplication1.Infrastructure;
using WebApplication1.UoWImplementation.Repositories;

namespace WebApplication1.UoWImplementation
{
    public class UnitOfWork : UnitOfWorkBase<MyDbContext>, IUnitOfWork
    {
        private IMyTestEntityRepository _myTestEntityRepository;

        public UnitOfWork(MyDbContext context) : base(context)
        {
        }

        public IMyTestEntityRepository MyTestEntity { get { return _myTestEntityRepository ??= new MyTestEntityRepository(_context); } }
    }
}
