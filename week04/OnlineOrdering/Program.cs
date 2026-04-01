using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P200", 25, 2));

        // Customer 2 (International)
        Address address2 = new Address("45 Bree Street", "Cape Town", "WC", "South Africa");
        Customer customer2 = new Customer("Katleho Selwana", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P300", 800, 1));
        order2.AddProduct(new Product("Headphones", "P400", 150, 1));
        order2.AddProduct(new Product("Charger", "P500", 30, 2));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");

        Console.WriteLine("\n-----------------------\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}
