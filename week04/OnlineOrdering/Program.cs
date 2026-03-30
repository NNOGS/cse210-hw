using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        //------ First Order--------
        Address address1 = new Address("123 Main st", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Laptop", "P100", 800, 1);
        Product product2 = new Product("Mouse", "P200", 25, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackagingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine("\n-------------\n");

        // --------------Second Order---------------

        Address address2 = new Address("45 Lagos Street", "Lagos", "Lagos", "Nigeria");
        Customer customer2 = new Customer("Obinna Njoku", address2);

        Product product3 = new Product("Keyboard", "P300", 50, 1);
        Product product4 = new Product("Monitor", "P400", 200, 1);
        Product product5 = new Product("USB Cable", "P500", 10, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetPackagingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");

    }
}