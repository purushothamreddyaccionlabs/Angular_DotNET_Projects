using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("062ba027-d986-45c9-b530-d8cf3ef9e3bb"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("4bf45d76-7d26-4561-ac69-126a8b0db4ed"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("40c3e47a-62b9-4dac-bc9e-1280c3a1c705"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Region
            var regions = new List<Region>
            {
                new Region()
                {
                    Id = Guid.Parse("f72fd8d6-7bbf-4912-a331-3db5406ed059"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("4d590d3c-1a2c-404d-81d4-ddd965600ad5"),
                    Name = "North Land",
                    Code = "NTL",
                    RegionImageUrl = "https://i.imgur.com/BweUjJK.jpeg"
                },
                new Region()
                {
                    Id = Guid.Parse("be195175-e8ca-4da7-95b9-89377a378715"),
                    Name = "Blay of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },

                new Region()
                {
                    Id = Guid.Parse("f72fd8d6-7bbf-4912-a331-3db5406ed056"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("a113c477-3389-4500-9176-bc4b8de0a6fa"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://i.imgur.com/uNZ2GwE.jpeg"
                },
                new Region()
                {
                    Id = Guid.Parse("fca2fe0f-0967-4e7f-b379-a16871b887ca"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);

          
        }
    }
}
