using Employee_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Core.Data
{
    public class Employee_CoreDbContext : DbContext
    {
        public Employee_CoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
