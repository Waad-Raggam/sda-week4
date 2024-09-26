using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce
{
    class DatabaseContext : DbContext
    {
        // erd
        // category
        public DbSet<Category> Category {get; set;}
        // public DbSet<Product> Product {get; set;}

        // constructor is for db configuration
        public DatabaseContext(DbContextOptions options) : base(options) {

        }
    }
}
