using Microsoft.EntityFrameworkCore;
using MigrationDemo.DataModels;

namespace MigrationDemo.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
