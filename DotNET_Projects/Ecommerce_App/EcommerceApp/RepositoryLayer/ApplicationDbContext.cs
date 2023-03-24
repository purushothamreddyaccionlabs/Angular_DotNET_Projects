using EcommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.RepositoryLayer
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Grocery> groceries { get; set; }
        public DbSet<Clothes> clothes { get; set; }
        public DbSet<Electronics> electronics { get; set; }
    }
}
