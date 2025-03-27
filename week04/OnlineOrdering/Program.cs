using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();
        
        // ORDER 1
        Customer customer1 = new Customer("Julio", "Emilio Tuero", "Mexico", "Coyoacan", "Mexico");
        Product product1 = new Product("shampoo", 101, 2, 2);
        Product product2 = new Product("soap", 102, 3, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Price : ${order1.CalculateTotalPrice()}\n\n");

        // ORDER 2
        Customer customer2 = new Customer("David", "Joseph Smith", "Salt Lake", "Utah", "USA");
        Product product3 = new Product("cheese", 103, 2, 3);
        Product product4 = new Product("bread", 104, 3, 3);
        Product product5 = new Product("water", 105, 1, 10);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Price : ${order2.CalculateTotalPrice()}\n\n");
        
    }
}