using PostcardsWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PostcardsWeb.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Border> Borders { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Coloration> Colorations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Orientation> Orientations { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<CardIdent> CardIdents { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Border>().HasData(
                new Border { BorderId = 1, Name = "Smooth" },
                new Border { BorderId = 2, Name = "Recortado" }
                );

            modelBuilder.Entity<Material>().HasData(
                new Material { MatId = 1, Name = "Coconut" },
                new Material { MatId = 2, Name = "Cork" },
                new Material { MatId = 3, Name = "Metal/Copper" },
                new Material { MatId = 4, Name = "Paper/Cardboard" },
                new Material { MatId = 5, Name = "Tile/Ceramics" },
                new Material { MatId = 6, Name = "Wood" }
                );

            modelBuilder.Entity<Orientation>().HasData(
                new Orientation { OrientId = 1, Name = "Horizontal" },
                new Orientation { OrientId = 2, Name = "Vertical" },
                new Orientation { OrientId = 3, Name = "Horizontal/Vertical" },
                new Orientation { OrientId = 4, Name = "None" }
                );

            modelBuilder.Entity<Size>().HasData(
                new Size { SizeId = 1, Name = "Regular" },
                new Size { SizeId = 2, Name = "Big" },
                new Size { SizeId = 3, Name = "Small" },
                new Size { SizeId = 4, Name = "Round" },
                new Size { SizeId = 5, Name = "Square" },
                new Size { SizeId = 6, Name = "N/D" }
                );

            modelBuilder.Entity<Shape>().HasData(
                new Shape { ShapeId = 1, Name = "Rectangular" },
                new Shape { ShapeId = 2, Name = "Rounded" },
                new Shape { ShapeId = 3, Name = "Squared" },
                new Shape { ShapeId = 4, Name = "Flower" },
                new Shape { ShapeId = 5, Name = "Triangular" }
                );

            modelBuilder.Entity<Coloration>().HasData(
                new Coloration { ColorId = 1, Name = "Colored" },
                new Coloration { ColorId = 2, Name = "Black & White" },
                new Coloration { ColorId = 3, Name = "Sepia" },
                new Coloration { ColorId = 4, Name = "Other" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
