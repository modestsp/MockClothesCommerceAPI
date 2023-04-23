using AutoMapper;
using MockClothesCommerceAPI.Dtos;
using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Helper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Category
        CreateMap<Category, GetCategoryResponse>();

        // Product
        CreateMap<CreateProductRequest, Product>();
        CreateMap<Product, CreateProductResponse>();
        CreateMap<Product, GetProductResponse>();

        // User
        CreateMap<CreateUserRequest, User>();

        // Review
        CreateMap<CreateReviewRequest, Review>();
        CreateMap<Review, CreateReviewResponse>();
        CreateMap<Review, GetReviewResponse>()
            .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User.Username))
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id))
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.Product.Id));

    }
}

