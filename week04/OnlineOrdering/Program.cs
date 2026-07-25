using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)

        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 45, 1));

        // Order 2 (Outside USA)

        Address address2 = new Address(
            "456 King Road",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer("Maria Garcia", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "P200", 250, 2));
        order2.AddProduct(new Product("Headphones", "P201", 80, 1));

        // Display Order 1

        Console.WriteLine("ORDER 1");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice()}");

        Console.WriteLine("\n----------------------------\n");

        // Display Order 2

        Console.WriteLine("ORDER 2");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice()}");
    }
}