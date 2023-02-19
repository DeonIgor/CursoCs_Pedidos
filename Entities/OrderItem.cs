using System;

namespace Entities;

public class OrderItem {
    public int Quantity { get; set; }
    public Double Price { get; set; }
    public Product Product { get; set; }

    public OrderItem(int quantity, double price, Product product)
    {
        Quantity = quantity;
        Price = price;
        this.Product = product;
    }

    public Double SubTotal() 
    {
        return Quantity * Price;
    }
}