using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Dtos;

public class CreateProductRequest
{
  public string Name { get; set; }
  public string Description { get; set; }
  public decimal Price { get; set; } = 0;
  public decimal Stars { get; set; } = 0;
  public int CategoryId { get; set; }
  public List<string>? Tags { get; set; }
}

public class UpdateProductRequest
{
  public string Name { get; set; }
  public string Description { get; set; }
  public decimal Price { get; set; }
  public List<string> Tags { get; set; }
}

public class CreateProductResponse
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public decimal Price { get; set; }
  public decimal Stars { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime ModifiedAt { get; set; }
  public int CategoryId { get; set; }
  //   public List<Review>? Reviews { get; set; }
  public List<string>? Tags { get; set; }
}

public class GetProductResponse
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public decimal Price { get; set; }
  public decimal Stars { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime ModifiedAt { get; set; }
  public string? Url { get; set; }
  public string? PhotographerName { get; set; }
  public string? PhotographerUrl { get; set; }
  public int CategoryId { get; set; }
  public List<string>? Tags { get; set; }
}