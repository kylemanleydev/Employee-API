using Employee_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Core.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
