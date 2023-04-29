using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Data.Seed;
public static class ProductSeed
{
  public static void Initialize(WebApplication app)
  {
    var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetService<DataContext>();

    context.Database.EnsureCreated();
    if (!context.Products.Any())
    {
      context.Products.Add(new Product
      {
        Id = 1,
        Name = "Love Disorder blue",
        Url = "https://images.unsplash.com/photo-1620231109648-302d034cb29b?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Description = "Love Disorder blue is a beautiful blue hat that you can wear ",
        Stars = 5,
        CreatedAt = DateTime.Parse("16/1/2023 8:41:28"),
        ModifiedAt = DateTime.Parse("16/1/2023 8:41:28"),
        CategoryId = 1,
        PhotographerName = "Andre Styles",
        PhotographerUrl = "https://unsplash.com/es/@lovedisorder",
        Tags = new List<string> { "men", "hats", "blue" },
        Price = 20
      });

      context.Products.Add(new Product
      {
        Id = 2,
        Name = "705 Black Hat",
        Url = "https://images.unsplash.com/photo-1618354691792-d1d42acfd860?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=715&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 2:42:56"),
        ModifiedAt = DateTime.Parse("2023-01-16 2:42:56"),
        CategoryId = 1,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Ryan Hoffman",
        PhotographerUrl = "https://unsplash.com/es/@ryanhoffman007",
        Tags = new List<string> {
            "men",
            "hats",
            "black",
            "705"
        },
        Price = 21
      });
      context.Products.Add(new Product
      {
        Id = 3,
        Name = "Red Fast",
        Url = "https://images.unsplash.com/photo-1527813972756-2890936000e9?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=991&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 5:43:59"),
        ModifiedAt = DateTime.Parse("2023-01-16 5:43:59"),
        CategoryId = 1,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "LexScope",
        PhotographerUrl = "https://unsplash.com/es/@lexscope",
        Tags = new List<string> {
            "men",
            "hats",
            "red"
        },
        Price = 25
      });
      context.Products.Add(new Product
      {
        Id = 4,
        Name = "Pink hats",
        Url = "https://images.unsplash.com/photo-1559560823-8b9e5becd4ba?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 8:44:40"),
        ModifiedAt = DateTime.Parse("2023-01-16 8:44:40"),
        CategoryId = 1,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "munish sawant",
        PhotographerUrl = "https://unsplash.com/es/@munish707",
        Tags = new List<string> {
            "women",
            "hats",
            "pink"
        },
        Price = 27
      });
      context.Products.Add(new Product
      {
        Id = 5,
        Name = "Brown hats",
        Url = "https://images.unsplash.com/photo-1561578428-c50f678e6cbb?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1169&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 8:45:19"),
        ModifiedAt = DateTime.Parse("2023-01-16 8:45:19"),
        CategoryId = 1,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Megan Bucknall",
        PhotographerUrl = "https://unsplash.com/es/@meganmarkham",
        Tags = new List<string> {
            "men,hats",
            "brown",
            "classic"
        },
        Price = 30
      });
      context.Products.Add(new Product
      {
        Id = 6,
        Name = "7 3/8 Hats",
        Url = "https://images.unsplash.com/photo-1533055640609-24b498dfd74c?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1074&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 8:47:25"),
        ModifiedAt = DateTime.Parse("2023-01-16 8:47:25"),
        CategoryId = 1,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "JOSHUA COLEMAN",
        PhotographerUrl = "https://unsplash.com/es/@joshstyle",
        Tags = new List<string> {
            "men",
            "hats",
            "classic"
        },
        Price = 22
      });
      context.Products.Add(new Product
      {
        Id = 7,
        Name = "ADVAN7",
        Url = "https://images.unsplash.com/photo-1576871337632-b9aef4c17ab9?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 8:48:16"),
        ModifiedAt = DateTime.Parse("2023-01-16 8:48:16"),
        CategoryId = 1,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Fábio Alves",
        PhotographerUrl = "https://unsplash.com/es/@barncreative",
        Tags = new List<string> {
            "men",
            "women",
            "hats",
            "black",
            "yellow"
        },
        Price = 28
      });
      context.Products.Add(new Product
      {
        Id = 8,
        Name = "VA RVCA",
        Url = "https://images.unsplash.com/photo-1556306535-0f09a537f0a3?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 8:48:58"),
        ModifiedAt = DateTime.Parse("2023-01-16 8:48:58"),
        CategoryId = 1,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Claudio Schwarz",
        PhotographerUrl = "https://unsplash.com/es/@purzlbaum",
        Tags = new List<string> {
            "men",
            "hats",
            "grey",
            "rvca"
        },
        Price = 35
      });
      context.Products.Add(new Product
      {
        Id = 9,
        Name = "Beach Hat",
        Url = "https://images.unsplash.com/photo-1572307480813-ceb0e59d8325?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 8:49:35"),
        ModifiedAt = DateTime.Parse("2023-01-16 8:49:35"),
        CategoryId = 1,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Mary Oloumi",
        PhotographerUrl = "https://unsplash.com/es/@laviebohemo",
        Tags = new List<string> {
            "women",
            "hats",
            "summer",
            "pink"
        },
        Price = 24
      });
      context.Products.Add(new Product
      {
        Id = 10,
        Name = "Sapphire Ring",
        Url = "https://images.unsplash.com/photo-1586104237516-5b7075e00d45?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 11:53:34"),
        ModifiedAt = DateTime.Parse("2023-01-16 11:53:34"),
        CategoryId = 2,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Sabrianna",
        PhotographerUrl = "https://unsplash.com/es/@sabrinnaringquist",
        Tags = new List<string> {
            "women",
            "sapphire",
            "ring"
        },
        Price = 50
      });
      context.Products.Add(new Product
      {
        Id = 11,
        Name = "Bracelet",
        Url = "https://images.unsplash.com/photo-1619119069152-a2b331eb392a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1171&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 11:54:35"),
        ModifiedAt = DateTime.Parse("2023-01-16 11:54:35"),
        CategoryId = 2,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Sabrianna",
        PhotographerUrl = "https://unsplash.com/es/@sabrinnaringquist",
        Tags = new List<string> {
            "men",
            "women",
            "bracelet",
            "silver"
        },
        Price = 100
      });
      context.Products.Add(new Product
      {
        Id = 12,
        Name = "Golden Earring",
        Url = "https://images.unsplash.com/photo-1614606139527-3afb46eebcd7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=627&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 11:56:37"),
        ModifiedAt = DateTime.Parse("2023-01-16 11:56:37"),
        CategoryId = 2,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Sama Hosseini",
        PhotographerUrl = "https://unsplash.com/es/@samahosseini",
        Tags = new List<string> {
            "women",
            "earring",
            "gold"
        },
        Price = 75
      });
      context.Products.Add(new Product
      {
        Id = 13,
        Name = "Silver Necklace",
        Url = "https://images.unsplash.com/photo-1588444968576-f8fe92ce56fd?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 11:57:32"),
        ModifiedAt = DateTime.Parse("2023-01-16 11:57:32"),
        CategoryId = 2,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Sabrianna",
        PhotographerUrl = "https://unsplash.com/es/@sabrinnaringquist",
        Tags = new List<string> {
            "women",
            "silver","necklace"
        },
        Price = 100
      });
      context.Products.Add(new Product
      {
        Id = 14,
        Name = "Green Emerald Necklace",
        Url = "https://images.unsplash.com/photo-1599643477877-530eb83abc8e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 11:58:05"),
        ModifiedAt = DateTime.Parse("2023-01-16 11:58:05"),
        CategoryId = 2,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Andres Vera",
        PhotographerUrl = "https://unsplash.com/es/@canonvera",
        Tags = new List<string> {
            "women",
            "green","emerald","necklace"
        },
        Price = 150
      });
      context.Products.Add(new Product
      {
        Id = 15,
        Name = "Pearls Necklace",
        Url = "https://images.unsplash.com/photo-1515562141207-7a88fb7ce338?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 11:58:39"),
        ModifiedAt = DateTime.Parse("2023-01-16 11:58:39"),
        CategoryId = 2,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Cornelia Ng",
        PhotographerUrl = "https://unsplash.com/es/@corneliang",
        Tags = new List<string> {
            "women",
            "necklace",
            "pearls"
        },
        Price = 80
      });
      context.Products.Add(new Product
      {
        Id = 16,
        Name = "Golden Bracelet",
        Url = "https://images.unsplash.com/photo-1602173574767-37ac01994b2a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 11:59:14"),
        ModifiedAt = DateTime.Parse("2023-01-16 11:59:14"),
        CategoryId = 2,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Nati Melnychuk",
        PhotographerUrl = "https://unsplash.com/es/@natinati",
        Tags = new List<string> {
            "men",
            "women",
            "bracelet",
            "gold"
        },
        Price = 80
      });
      context.Products.Add(new Product
      {
        Id = 17,
        Name = "Moon Necklace",
        Url = "https://images.unsplash.com/photo-1599643478518-a784e5dc4c8f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 11:59:39"),
        ModifiedAt = DateTime.Parse("2023-01-16 11:59:39"),
        CategoryId = 2,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Andres Vera",
        PhotographerUrl = "https://unsplash.com/es/@canonvera",
        Tags = new List<string> {
            "women",
            "moon",
            "necklace"
        },
        Price = 79
      });
      context.Products.Add(new Product
      {
        Id = 18,
        Name = "Bee Pin",
        Url = "https://images.unsplash.com/photo-1610705260766-0b37b093ce56?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=987&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 12:00:43"),
        ModifiedAt = DateTime.Parse("2023-01-16 12:00:43"),
        CategoryId = 2,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Amy Lewis",
        PhotographerUrl = "https://unsplash.com/es/@amylewisphotography",
        Tags = new List<string> {
            "women",
            "pin",
            "bee",
            "gold"
        },
        Price = 20
      });
      context.Products.Add(new Product
      {
        Id = 19,
        Name = "Blue pant",
        Url = "https://images.unsplash.com/photo-1633700720785-32a7977a9ef1?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 12:08:39"),
        ModifiedAt = DateTime.Parse("2023-01-16 12:08:39"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Ellie Ellien",
        PhotographerUrl = "https://unsplash.com/es/@ellienelie",
        Tags = new List<string> {
            "women",
            "pant",
            "blue",
            "classic"
        },
        Price = 20
      });

      context.Products.Add(new Product
      {
        Id = 20,
        Name = "Jeans",
        Url = "https://images.unsplash.com/photo-1604176354204-9268737828e4?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 12:09:34"),
        ModifiedAt = DateTime.Parse("2023-01-16 12:09:34"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Maude Frédérique Lavoie",
        PhotographerUrl = "https://unsplash.com/es/@maudefl",
        Tags = new List<string> {
            "women",
            "men",
            "jean",
            "classic"
        },
        Price = 15
      });
      context.Products.Add(new Product
      {
        Id = 21,
        Name = "Short pant",
        Url = "https://images.unsplash.com/photo-1585145197082-dba095ba01ab?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=702&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 12:10:06"),
        ModifiedAt = DateTime.Parse("2023-01-16 12:10:06"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "engin akyurt",
        PhotographerUrl = "https://unsplash.com/es/@enginakyurt",
        Tags = new List<string> {
            "women",
            "short",
            "classic",
            "pant"
        },
        Price = 18
      });
      context.Products.Add(new Product
      {
        Id = 22,
        Name = "Dark blue short pant",
        Url = "https://images.unsplash.com/photo-1585145197502-8f36802f0a26?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=668&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 12:11:05"),
        ModifiedAt = DateTime.Parse("2023-01-16 12:11:05"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "engin akyurt",
        PhotographerUrl = "https://unsplash.com/es/@enginakyurt",
        Tags = new List<string> {
            "women",
            "dark blue",
            "short","pant"
        },
        Price = 18
      });
      context.Products.Add(new Product
      {
        Id = 23,
        Name = "Ripped shorts",
        Url = "https://images.unsplash.com/photo-1591195853828-11db59a44f6b?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 12:11:52"),
        ModifiedAt = DateTime.Parse("2023-01-16 12:11:52"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "engin akyurt",
        PhotographerUrl = "https://unsplash.com/es/@enginakyurt",
        Tags = new List<string> {
            "women",
            "short",
            "ripped",
            "pant"
        },
        Price = 19
      });
      context.Products.Add(new Product
      {
        Id = 24,
        Name = "Pink pant",
        Url = "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 12:12:13"),
        ModifiedAt = DateTime.Parse("2023-01-16 12:12:13"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "engin akyurt",
        PhotographerUrl = "https://unsplash.com/es/@enginakyurt",
        Tags = new List<string> {
            "women","pink","pant"
        },
        Price = 26
      });
      context.Products.Add(new Product
      {
        Id = 25,
        Name = "Classic jean",
        Url = "https://images.unsplash.com/photo-1595272832990-82e5cd240255?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 12:12:52"),
        ModifiedAt = DateTime.Parse("2023-01-16 12:12:52"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Artem Beliaikin",
        PhotographerUrl = "https://unsplash.com/es/@belart84",
        Tags = new List<string> {
            "women",
            "classic",
            "jean"
        },
        Price = 25
      });
      context.Products.Add(new Product
      {
        Id = 26,
        Name = "Light Blue pant",
        Url = "https://images.unsplash.com/photo-1584370848010-d7fe6bc767ec?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 6:13:36"),
        ModifiedAt = DateTime.Parse("2023-01-16 6:13:36"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "engin akyurt",
        PhotographerUrl = "https://unsplash.com/es/@enginakyurt",
        Tags = new List<string> {
            "women",
            "light",
            "blue",
            "pant"
        },
        Price = 76
      });
      context.Products.Add(new Product
      {
        Id = 27,
        Name = "T-shirt mix",
        Url = "https://images.unsplash.com/photo-1596609548086-85bbf8ddb6b9?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:37:51"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:37:51"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Artem Beliaikin",
        PhotographerUrl = "https://unsplash.com/es/@belart84",
        Tags = new List<string> {
            "women",
            "shirt",
            "tshirt"
        },
        Price = 14
      });
      context.Products.Add(new Product
      {
        Id = 28,
        Name = "Dress",
        Url = "https://images.unsplash.com/photo-1589810635657-232948472d98?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:38:56"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:38:56"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "engin akyurt",
        PhotographerUrl = "https://unsplash.com/es/@enginakyurt",
        Tags = new List<string> {
            "women",
            "dress",
            "light blue"
        },
        Price = 28
      });
      context.Products.Add(new Product
      {
        Id = 29,
        Name = "White dress",
        Url = "https://images.unsplash.com/photo-1596484552993-aec4311d3381?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:39:27"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:39:27"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Artem Beliaikin",
        PhotographerUrl = "https://unsplash.com/es/@belart84",
        Tags = new List<string> {
            "women",
            "white",
            "dress"
        },
        Price = 35
      });
      context.Products.Add(new Product
      {
        Id = 30,
        Name = "Dress Mix",
        Url = "https://images.unsplash.com/photo-1490481651871-ab68de25d43d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:40:34"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:40:34"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Priscilla Du Preez",
        PhotographerUrl = "https://unsplash.com/es/@priscilladupreez",
        Tags = new List<string> {
            "women",
            "dress",
            "mix"
        },
        Price = 35
      });
      context.Products.Add(new Product
      {
        Id = 31,
        Name = "Coke White shirt",
        Url = "https://images.unsplash.com/photo-1533077650324-5cca2426cd20?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:41:08"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:41:08"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Allef Vinicius",
        PhotographerUrl = "https://unsplash.com/es/@seteph",
        Tags = new List<string> {
            "women",
            "coke",
            "white",
            "shirt"
        },
        Price = 20
      });
      context.Products.Add(new Product
      {
        Id = 32,
        Name = "Black V sign",
        Url = "https://images.unsplash.com/photo-1503342217505-b0a15ec3261c?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 13:43:32"),
        ModifiedAt = DateTime.Parse("2023-01-16 13:43:32"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "ian dooley",
        PhotographerUrl = "https://unsplash.com/es/@sadswim",
        Tags = new List<string> {
            "women",
            "black",
            "shirt"
        },
        Price = 40
      });
      context.Products.Add(new Product
      {
        Id = 33,
        Name = "White Sandals",
        Url = "https://images.unsplash.com/photo-1619510331283-a46c425e48bb?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:47:54"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:47:54"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Zoe",
        PhotographerUrl = "https://unsplash.com/es/@_imd",
        Tags = new List<string> {
            "women",
            "white",
            "sandals"
        },
        Price = 40
      });
      context.Products.Add(new Product
      {
        Id = 34,
        Name = "High heels flowers",
        Url = "https://images.unsplash.com/photo-1543163521-1bf539c55dd2?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:48:44"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:48:44"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Mohammad Metri",
        PhotographerUrl = "https://unsplash.com/es/@mohammadmetri",
        Tags = new List<string> {
            "women",
            "high heels",
            "heels",
            "flower"
        },
        Price = 35
      });
      context.Products.Add(new Product
      {
        Id = 35,
        Name = "Pink shoes",
        Url = "https://images.unsplash.com/photo-1499013819532-e4ff41b00669?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:49:15"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:49:15"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Alexandra Gorn",
        PhotographerUrl = "https://unsplash.com/es/@alexagorn",
        Tags = new List<string> {
            "women",
            "pink",
            "shoes"
        },
        Price = 40
      });
      context.Products.Add(new Product
      {
        Id = 36,
        Name = "Brown Boots",
        Url = "https://images.unsplash.com/photo-1531310197839-ccf54634509e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=765&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:50:24"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:50:24"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Verity Sanders",
        PhotographerUrl = "https://unsplash.com/es/@veritysanders",
        Tags = new List<string> {
            "women",
            "brown",
            "boots"
        },
        Price = 45
      });
      context.Products.Add(new Product
      {
        Id = 37,
        Name = "Black high heels",
        Url = "https://images.unsplash.com/photo-1515347619252-60a4bf4fff4f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1185&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:51:01"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:51:01"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Andrew Tanglao",
        PhotographerUrl = "https://unsplash.com/es/@andrewtanglao",
        Tags = new List<string> {
            "women",
            "black",
            "high heels",
            "heels"
        },
        Price = 46
      });
      context.Products.Add(new Product
      {
        Id = 38,
        Name = "New Balance X-90 Pink",
        Url = "https://images.unsplash.com/photo-1551107696-a4b0c5a0d9a2?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1112&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:51:54"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:51:54"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Maksim Larin",
        PhotographerUrl = "https://unsplash.com/es/@maksimcul8r",
        Tags = new List<string> {
            "women",
            "new balance",
            "pink",
            "shoes"
        },
        Price = 35
      });
      context.Products.Add(new Product
      {
        Id = 39,
        Name = "Light Pink High Heels",
        Url = "https://images.unsplash.com/photo-1621996659490-3275b4d0d951?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=765&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:52:29"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:52:29"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Kier... in Sight",
        PhotographerUrl = "https://unsplash.com/es/@kierinsight",
        Tags = new List<string> {
            "women",
            "pink",
            "light pink",
            "high heels",
            "heels"
        },
        Price = 40
      });
      context.Products.Add(new Product
      {
        Id = 40,
        Name = "Nike shoes pink",
        Url = "https://images.unsplash.com/photo-1511556532299-8f662fc26c06?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 13:52:59"),
        ModifiedAt = DateTime.Parse("2023-01-16 13:52:59"),
        CategoryId = 3,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Malvestida",
        PhotographerUrl = "https://unsplash.com/es/@malvestida",
        Tags = new List<string> {
            "women",
            "nike",
            "shoes",
            "pink"
        },
        Price = 34
      });
      context.Products.Add(new Product
      {
        Id = 41,
        Name = "Acne Black Pant",
        Url = "https://images.unsplash.com/photo-1624378440847-4a64ee1a889d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1164&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:54:14"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:54:14"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Matt Moloney",
        PhotographerUrl = "https://unsplash.com/es/@mattmoloney",
        Tags = new List<string> {
            "men",
            "acne",
            "black",
            "pant"
        },
        Price = 25
      });
      context.Products.Add(new Product
      {
        Id = 42,
        Name = "Classic Pants",
        Url = "https://images.unsplash.com/photo-1542272604-787c3835535d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1026&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:54:49"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:54:49"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Mnz",
        PhotographerUrl = "https://unsplash.com/es/@mnzoutfits",
        Tags = new List<string> {
            "men",
            "classic",
            "pant"
        },
        Price = 30
      });
      context.Products.Add(new Product
      {
        Id = 43,
        Name = "CK pant",
        Url = "https://images.unsplash.com/photo-1584956795062-4a8b589f7b5e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=649&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:55:12"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:55:12"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Omid Armin",
        PhotographerUrl = "https://unsplash.com/es/@omidarmin",
        Tags = new List<string> {
            "men",
            "calvin klein",
            "pant",
            "classic"
        },
        Price = 35
      });
      context.Products.Add(new Product
      {
        Id = 44,
        Name = "Acne Dark Blue Pant",
        Url = "https://images.unsplash.com/photo-1624378441864-6eda7eac51cb?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=688&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:55:42"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:55:42"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Matt Moloney",
        PhotographerUrl = "https://unsplash.com/es/@mattmoloney",
        Tags = new List<string> {
            "men",
            "acne",
            "dark blue",
            "blue",
            "pant"
        },
        Price = 27
      });
      context.Products.Add(new Product
      {
        Id = 45,
        Name = "Ripped Jeans",
        Url = "https://images.unsplash.com/photo-1547597466-50406ff4f363?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:56:09"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:56:09"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Greg Raines",
        PhotographerUrl = "https://unsplash.com/es/@lionsdenpro",
        Tags = new List<string> {
            "men",
            "pant",
            "ripped",
            "ripped pant"
        },
        Price = 26
      });
      context.Products.Add(new Product
      {
        Id = 46,
        Name = "V blue jean",
        Url = "https://images.unsplash.com/photo-1511196044526-5cb3bcb7071b?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=764&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:56:38"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:56:38"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Creaslim",
        PhotographerUrl = "https://unsplash.com/es/@creaslim",
        Tags = new List<string> {
            "men",
            "blue",
            "jean",
            "pant"
        },
        Price = 38
      });
      context.Products.Add(new Product
      {
        Id = 47,
        Name = "Levi's Classic Pants",
        Url = "https://images.unsplash.com/photo-1605518216938-7c31b7b14ad0?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1009&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 16:57:08"),
        ModifiedAt = DateTime.Parse("2023-01-16 16:57:08"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Eduardo Pastor",
        PhotographerUrl = "https://unsplash.com/es/@eduardopastor",
        Tags = new List<string> {
            "men",
            "levi",
            "classic",
            "pant"
        },
        Price = 37
      });
      context.Products.Add(new Product
      {
        Id = 48,
        Name = "Pants Mix",
        Url = "https://images.unsplash.com/photo-1560243563-062bfc001d68?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 13:57:46"),
        ModifiedAt = DateTime.Parse("2023-01-16 13:57:46"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Ian deng",
        PhotographerUrl = "https://unsplash.com/es/@landall",
        Tags = new List<string> {
            "men",
            "pant",
            "mix"
        },
        Price = 40
      });
      context.Products.Add(new Product
      {
        Id = 49,
        Name = "Bordeaux Dress Shirt",
        Url = "https://images.unsplash.com/photo-1602810318660-d2c46b750f88?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=987&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 11:00:20"),
        ModifiedAt = DateTime.Parse("2023-01-16 11:00:20"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Nimble Made",
        PhotographerUrl = "https://unsplash.com/es/@nimblemade",
        Tags = new List<string> {
            "nimble made",
            "bordeaux",
            "dress shirt",
            "shirt"
        },
        Price = 50
      });
      context.Products.Add(new Product
      {
        Id = 50,
        Name = "White classic dress shirt",
        Url = "https://images.unsplash.com/photo-1603252109303-2751441dd157?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:00:57"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:00:57"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Nimble Made",
        PhotographerUrl = "https://unsplash.com/es/@nimblemade",
        Tags = new List<string> {
            "nimble made",
            "classic",
            "white",
            "dress shirt",
            "shirt"
        },
        Price = 49
      });
      context.Products.Add(new Product
      {
        Id = 51,
        Name = "FC black shirt",
        Url = "https://images.unsplash.com/photo-1647243498368-8c19cf82031a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=715&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:01:22"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:01:22"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Ryan Grice",
        PhotographerUrl = "https://unsplash.com/es/@gricey_visuals",
        Tags = new List<string> {
            "men",
            "black",
            "shirt",
            "fc"
        },
        Price = 25
      });
      context.Products.Add(new Product
      {
        Id = 52,
        Name = "LSKD black shirt",
        Url = "https://images.unsplash.com/photo-1618453292459-53424b66bb6a?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=764&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:01:54"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:01:54"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Sven Ciupka",
        PhotographerUrl = "https://unsplash.com/es/@svenciupkab",
        Tags = new List<string> {
            "men",
            "lskd",
            "black shirt",
            "shirt"
        },
        Price = 28
      });
      context.Products.Add(new Product
      {
        Id = 53,
        Name = "button down shirt",
        Url = "https://images.unsplash.com/photo-1573766713733-18f875c7892d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=689&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:02:56"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:02:56"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Bannon Morrissy",
        PhotographerUrl = "https://unsplash.com/es/@bannon15",
        Tags = new List<string> {
            "men",
            "button down shirt",
            "shirt"
        },
        Price = 65
      });
      context.Products.Add(new Product
      {
        Id = 54,
        Name = "Light Blue shirt",
        Url = "https://images.unsplash.com/photo-1564584217132-2271feaeb3c5?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:03:17"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:03:17"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Cristofer Maximilian",
        PhotographerUrl = "https://unsplash.com/es/@cristofer",
        Tags = new List<string> {
            "men",
            "light blue",
            "blue",
            "shirt"
        },
        Price = 25
      });
      context.Products.Add(new Product
      {
        Id = 55,
        Name = "Blue jacket",
        Url = "https://images.unsplash.com/photo-1611312449408-fcece27cdbb7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=669&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:03:53"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:03:53"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Caio Coelho",
        PhotographerUrl = "https://unsplash.com/es/@smokthebikini",
        Tags = new List<string> {
            "men",
            "blue",
            "jacket",
            "classic"
        },
        Price = 89
      });
      context.Products.Add(new Product
      {
        Id = 56,
        Name = "Brown Jacket",
        Url = "https://images.unsplash.com/photo-1591047139829-d91aecb6caea?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=736&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 14:04:23"),
        ModifiedAt = DateTime.Parse("2023-01-16 14:04:23"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Tobias Tullius",
        PhotographerUrl = "https://unsplash.com/es/@tobiastu",
        Tags = new List<string> {
            "men",
            "jacket",
            "brown"
        },
        Price = 45
      });
      context.Products.Add(new Product
      {
        Id = 57,
        Name = "Und Arm Red sneakers",
        Url = "https://images.unsplash.com/photo-1617602269951-f41db1a32e09?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 14:06:03"),
        ModifiedAt = DateTime.Parse("2023-01-16 14:06:03"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Colin Lloyd",
        PhotographerUrl = "https://unsplash.com/es/@onthesearchforpineapples",
        Tags = new List<string> {
            "men",
            "shoes",
            "under armour",
            "red",
            "sneakers"
        },
        Price = 79
      });
      context.Products.Add(new Product
      {
        Id = 58,
        Name = "Air Jordan Black Shoes",
        Url = "https://images.unsplash.com/photo-1595909337002-3cdc3a590160?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:06:47"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:06:47"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Yalamber Limbu",
        PhotographerUrl = "https://unsplash.com/es/@yallu_yy",
        Tags = new List<string> {
            "men",
            "air jordan",
            "black shoes",
            "shoes"
        },
        Price = 100
      });
      context.Products.Add(new Product
      {
        Id = 59,
        Name = "Brown Boots",
        Url = "https://images.unsplash.com/photo-1608629601270-a0007becead3?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:07:10"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:07:10"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Noah Smith",
        PhotographerUrl = "https://unsplash.com/es/@noahsmith",
        Tags = new List<string> {
            "men",
            "brown boots",
            "boots"
        },
        Price = 78
      });
      context.Products.Add(new Product
      {
        Id = 60,
        Name = "Converse Classic Shoes",
        Url = "https://images.unsplash.com/photo-1494496195158-c3becb4f2475?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:07:34"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:07:34"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Mitchel Lensink",
        PhotographerUrl = "https://unsplash.com/es/@lensinkmitchel",
        Tags = new List<string> {
            "converse",
            "classic",
            "shoes"
        },
        Price = 67
      });
      context.Products.Add(new Product
      {
        Id = 61,
        Name = "lumberjack boots",
        Url = "https://images.unsplash.com/photo-1605812860427-4024433a70fd?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1035&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:08:32"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:08:32"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Maxim Hopman",
        PhotographerUrl = "https://unsplash.com/es/@nampoh",
        Tags = new List<string> {
            "men",
            "lumberjack boots",
            "boots"
        },
        Price = 120
      });
      context.Products.Add(new Product
      {
        Id = 62,
        Name = "Puma white shoes",
        Url = "https://images.unsplash.com/photo-1608231387042-66d1773070a5?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1074&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:08:56"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:08:56"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "The DK Photography",
        PhotographerUrl = "https://unsplash.com/es/@deepain108",
        Tags = new List<string> {
            "men",
            "puma",
            "white shoes",
            "shoes"
        },
        Price = 76
      });
      context.Products.Add(new Product
      {
        Id = 63,
        Name = "ecco brown shoes",
        Url = "https://images.unsplash.com/photo-1617689563472-c66428e83d17?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:09:25"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:09:25"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Mana Akbarzadegan",
        PhotographerUrl = "https://unsplash.com/es/@manaakbar",
        Tags = new List<string> {
            "men",
            "ecco",
            "brown shoes",
            "shoes"
        },
        Price = 89
      });
      context.Products.Add(new Product
      {
        Id = 64,
        Name = "Nike green shoes",
        Url = "https://images.unsplash.com/photo-1529810313688-44ea1c2d81d3?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=941&q=80",
        Stars = 0,
        CreatedAt = DateTime.Parse("2023-01-16 17:09:51"),
        ModifiedAt = DateTime.Parse("2023-01-16 17:09:51"),
        CategoryId = 4,
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
        PhotographerName = "Jayson Hinrichsen",
        PhotographerUrl = "https://unsplash.com/es/@jayson_hinrichsen",
        Tags = new List<string> {
            "men",
            "nike",
            "green shoes",
            "shoes"
        },
        Price = 90
      });
      context.SaveChanges();
    }
  }
}

