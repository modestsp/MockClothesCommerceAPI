using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<FavoriteProduct> Favorites { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var converter = new ValueConverter<List<string>, string>(
            v => string.Join(',', v),
            v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

        modelBuilder.Entity<Product>()
            .Property(p => p.Tags)
            .HasConversion(converter);

        modelBuilder.Entity<Product>()
           .HasOne(p => p.Category)
           .WithMany(c => c.Products)
           .HasForeignKey(p => p.CategoryId)
          .IsRequired();

        modelBuilder.Entity<Review>()
            .HasOne(p => p.Product)
            .WithMany(c => c.Reviews)
            .HasForeignKey(p => p.ProductId)
            .IsRequired();

        modelBuilder.Entity<Review>()
            .HasOne(p => p.User)
            .WithMany(c => c.Reviews)
            .HasForeignKey(p => p.UserId)
            .IsRequired();

        modelBuilder.Entity<FavoriteProduct>()
            .HasKey(fp => new { fp.UserId, fp.ProductId });
    }


}

