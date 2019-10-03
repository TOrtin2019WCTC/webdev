using System;
using Client.Models;
using Microsoft.EntityFrameworkCore;

namespace Client.Models
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }

}
