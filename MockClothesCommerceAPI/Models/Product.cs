namespace MockClothesCommerceAPI.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public decimal Price { get; set; } = 0;
    public decimal Stars { get; set; } = 0;
    public string PhotographerUrl { get; set; }
    public string PhotographerName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}

