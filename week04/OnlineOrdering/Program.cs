using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Peach Rd", "Atlanta", "GA", "USA");
        Customer customer1 = new Customer("Kyle West", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Pencil", "P006", 0.50, 10));
        order1.AddProduct(new Product("Eraser", "E002", 1.00, 2));

        Address address2 = new Address("55 Old Trafford St", "London", "England", "UK");
        Customer customer2 = new Customer("Sam Parker", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Lamp", "L003", 2.00, 4));
        order2.AddProduct(new Product("Desk", "D009", 1.25, 5));
        order2.AddProduct(new Product("Poster", "P005", 3.50, 1));

        DisplayOrder(order1);
        Console.WriteLine("--------------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order.GetTotalCost().ToString("0.00"));
    }
}