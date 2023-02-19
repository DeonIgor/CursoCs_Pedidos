using System.Globalization;
using System.Text;
using Enums;

namespace Entities;

public class Order {
    private DateTime Moment { get; set; }
    private OrderStatus Status { get; set; }
    private Client Client { get; set; }
    private List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        this.Client = client;
    }

    public void AddItem(OrderItem item) 
    {
        Items.Add(item);
    }

    public Boolean RemoveItem(OrderItem item) 
    {
        return Items.Remove(item);
    }

    public Double Total()
    {
        Double sum = 0;
        foreach(OrderItem item in Items) {
            sum = sum + item.SubTotal();
        }
        return sum;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("ORDER SUMMARY");
        sb.Append("Order moment: ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy hh:mm:ss"));
        sb.Append("Order status: ");
        sb.AppendLine(Status.ToString());
        sb.Append("Client: ");
        sb.Append(Client.Name + ' ');
        sb.Append(Client.birthDate.ToString("dd/MM/yyyy") + " - ");
        sb.AppendLine(Client.Email);
        sb.AppendLine("Order Items:");
        foreach(OrderItem item in Items) {
            sb.Append(item.Product.Name + ", $");
            sb.Append(item.Price + ", Quantity: ");
            sb.Append(item.Quantity + ", ");
            sb.AppendLine("SubTotal: $" + item.SubTotal());
        }
        sb.Append("Total price: $");
        sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

        return sb.ToString();
    }
}