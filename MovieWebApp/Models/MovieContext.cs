using Microsoft.EntityFrameworkCore;

namespace MovieWebApp.Models;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie { ID = 1, Title = "The Shawshank Redemption", Price = 7.99m },
            new Movie { ID = 2, Title = "The GodFather", Price = 8.99m },
            new Movie { ID = 3, Title = "The Dark Knight", Price = 9.99m },
            new Movie { ID = 4, Title = "The Lord Of the Rings", Price = 10.99m },
            new Movie { ID = 5, Title = "Pulp Fiction", Price = 6.99m },
            new Movie { ID = 6, Title = "Schindler's List", Price = 7.99m }
        );
    }
}