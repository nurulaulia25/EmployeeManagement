using EmployeeManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Context
{
    // turunan dari DbContext
    public class ApplicationDbContext : DbContext
    {
        // konfigurasi 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}

