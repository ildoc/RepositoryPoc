using WebApplication1.Infrastructure;
using WebApplication1.RepoImplementation.Repositories;

namespace WebApplication1.RepoImplementation
{
    public class RepositoryManager : RepositoryManagerBase<MyDbContext>, IRepositoryManager
    {
        private IMyTestEntityRepository _myTestEntityRepository;

        public RepositoryManager(MyDbContext context) : base(context)
        {
        }

        public IMyTestEntityRepository MyTestEntity { get { return _myTestEntityRepository ??= new MyTestEntityRepository(_context); } }
    }
}
