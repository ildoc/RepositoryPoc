using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MyDbContext : DbContext
    {
        public DbSet<MyTestEntity> MyTestEntities { get; set; }
    }
}
