namespace MockClothesCommerceAPI.Contracts.Product;

public record CreateProductRequest(
    string Name,
    string Description,
    decimal Price,
    //  int CategoryId,
    List<string> Tags);

