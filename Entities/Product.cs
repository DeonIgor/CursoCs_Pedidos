using System;

namespace Entities;

public class Product {
    public String Name { get; set; }
    public Double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}