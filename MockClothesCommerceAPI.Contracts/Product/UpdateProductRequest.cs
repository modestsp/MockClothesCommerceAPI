namespace MockClothesCommerceAPI.Contracts.Product;

public record UpdateProductRequest(
    string Name,
    string Description,
    decimal Price,
    //  int CategoryId,
    List<string> Tags);

