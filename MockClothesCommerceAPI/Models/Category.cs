﻿namespace MockClothesCommerceAPI.Models;

public class Category
{
  public int Id { get; set; }
  public string Name { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime ModifiedAt { get; set; }
  // public ICollection<Product> Products { get; set; }
}

