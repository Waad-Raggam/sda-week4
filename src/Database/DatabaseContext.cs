using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce
{
    class DatabaseContext : DbContext
    {
        public DbSet<Category> Category {get; set;}
    }
}
