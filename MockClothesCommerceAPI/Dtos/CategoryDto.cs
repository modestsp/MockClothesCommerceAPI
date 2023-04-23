using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Dtos;

public class CreateCategoryRequest
{
    public string Name { get; set; }
}


public class UpdateCategoryRequest
{

    public string Name { get; set; }
}

public class CreateCategoryResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class GetCategoryResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public ICollection<Product>? Products { get; set; }
}