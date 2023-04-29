using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Data.Seed;
public static class CategorySeed
{
  public static void Initialize(WebApplication app)
  {
    var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetService<DataContext>();

    context.Database.EnsureCreated();
    if (!context.Categories.Any())
    {
      context.Categories.Add(new Category
      {
        Id = 1,
        Name = "Hats",
        CreatedAt = DateTime.UtcNow,
        ModifiedAt = DateTime.UtcNow
      });

      context.Categories.Add(new Category
      {
        Id = 2,
        Name = "Jewelry",
        CreatedAt = DateTime.UtcNow,
        ModifiedAt = DateTime.UtcNow
      });


      context.Categories.Add(new Category
      {
        Id = 3,
        Name = "Women",
        CreatedAt = DateTime.UtcNow,
        ModifiedAt = DateTime.UtcNow
      });


      context.Categories.Add(new Category
      {
        Id = 4,
        Name = "Men",
        CreatedAt = DateTime.UtcNow,
        ModifiedAt = DateTime.UtcNow
      });

      context.SaveChanges();
    }
  }
}
