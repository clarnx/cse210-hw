using System;

class Program
{
    static void Main(string[] args)
    {
        {
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Customer customer1 = new Customer("John Doe", address1);
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", "L123", 999.99, 1));
            order1.AddProduct(new Product("Mouse", "M456", 25.50, 2));

            Console.WriteLine("Order 1 Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("\nOrder 1 Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"\nOrder 1 Total Price: ${order1.GetTotalPrice():0.00}\n");

            Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Jane Smith", address2);
            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Tablet", "T789", 499.99, 1));
            order2.AddProduct(new Product("Stylus", "S987", 19.99, 3));

            Console.WriteLine("Order 2 Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("\nOrder 2 Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"\nOrder 2 Total Price: ${order2.GetTotalPrice():0.00}");
        }
    }
}