using Entities;
using Enums;

internal class Program
{
    private static void Main(string[] args)
    {
    
        Console.WriteLine("Enter client data:");
        Console.Write("Name: ");
        String name = Console.ReadLine();
        Console.Write("Email: ");
        String email = Console.ReadLine();
        Console.Write("Birth Date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        Client client = new Client(name, email, birthDate);
        
        Console.WriteLine("Enter order data:");
        Console.Write("Status: ");
        OrderStatus status = (OrderStatus) Enum.Parse(typeof(OrderStatus), Console.ReadLine());
        Console.Write("How many itens to this order? ");
        int numItems = int.Parse(Console.ReadLine());            
        Order order = new Order(DateTime.Now, status, client);

        for(int i = 0; i < numItems; i++){
            Console.WriteLine($"Enter #{i+1} item data:");
            Console.Write("Product name: ");
            String productName = Console.ReadLine();
            Console.Write("Product price: ");
            Double price = Double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            order.AddItem(new OrderItem(quantity, price, new Product(productName, price)));
        }

        Console.WriteLine();
        Console.WriteLine(order);
    }
}
