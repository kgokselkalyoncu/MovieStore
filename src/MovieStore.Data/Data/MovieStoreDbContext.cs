using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieStore.Data.Models;

namespace MovieStore.Data.Data
{
    public class MovieStoreDbContext : DbContext
    {
        public MovieStoreDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        public virtual DbSet<Movie> Movies => Set<Movie>();
        public virtual DbSet<MovieGenre> MovieGenre => Set<MovieGenre>();
        public virtual DbSet<MovieInfo> MovieInfo => Set<MovieInfo>();
        public virtual DbSet<Actor> Actor => Set<Actor>();
        public virtual DbSet<Director> Director => Set<Director>();
        public virtual DbSet<MovieActor> MovieActor => Set<MovieActor>();
        public virtual DbSet<MovieDirector> MovieDirector => Set<MovieDirector>();
        public virtual DbSet<Customer> Customer => Set<Customer>();
        public virtual DbSet<CustomerOrder> CustomerOrder => Set<CustomerOrder>();
        public virtual DbSet<CustomerPurchasedMovie> CustomerPurchasedMovie => Set<CustomerPurchasedMovie>();
        public virtual DbSet<CustomerFavoriteMovieGenre> CustomerFavoriteMovieGenre => Set<CustomerFavoriteMovieGenre>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenre>().HasData(
                new MovieGenre { Id = 1, Name = "Aksiyon" },
                new MovieGenre { Id = 2, Name = "Macera" },
                new MovieGenre { Id = 3, Name = "Korku" },
                new MovieGenre { Id = 4, Name = "Komedi" },
                new MovieGenre { Id = 5, Name = "Animasyon" }
                );
        }

    }
}