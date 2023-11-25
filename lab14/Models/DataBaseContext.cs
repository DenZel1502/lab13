using Microsoft.EntityFrameworkCore;

namespace lab14.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options){}

        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
