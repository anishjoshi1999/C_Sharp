using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions):base(contextOptions)
        {
            
        }
        //Code-Approach
        public DbSet<Employees> Employees { get; set; }
    }
}
