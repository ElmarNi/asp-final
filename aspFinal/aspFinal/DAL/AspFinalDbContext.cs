using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspFinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace aspFinal.DAL
{
    public class AspFinalDbContext : IdentityDbContext<ApplicationUser>
    {
        public AspFinalDbContext(DbContextOptions<AspFinalDbContext> options) :base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Make> Makes { get; set; }

        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<Transmission> Transmissions { get; set; }

        public DbSet<Advertisement> Advertisements { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<CarDetailPhotos> CarDetailPhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
