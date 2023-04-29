using Microsoft.EntityFrameworkCore;
using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.Data.Seed;
using MockClothesCommerceAPI.Models;
using MockClothesCommerceAPI.Services.Category;
using MockClothesCommerceAPI.Services.Product;
using MockClothesCommerceAPI.Services.Review;
using MockClothesCommerceAPI.Services.User;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services.AddControllers();
  builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
  builder.Services.AddEndpointsApiExplorer();
  builder.Services.AddSwaggerGen();
  builder.Services.AddScoped<IUserService, UserService>();
  builder.Services.AddScoped<IProductService, ProductService>();
  builder.Services.AddScoped<IReviewService, ReviewService>();
  builder.Services.AddScoped<ICategoryService, CategoryService>();
  builder.Services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("MockClothesCommerce"));
}


var app = builder.Build();
CategorySeed.Initialize(app);
ProductSeed.Initialize(app);
UserSeed.Initialize(app);
ReviewSeed.Initialize(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

//app.UseExceptionHandler("/error");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
