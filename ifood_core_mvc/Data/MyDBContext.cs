using ifood_core_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace ifood_core_mvc.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }  

        public DbSet<Product> Products { get; set; }

    }
}
