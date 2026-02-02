using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "London", "", "United Kingdom");
        Customer customer1 = new Customer("John Taylor", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book of Mormon", "H01Y", 5.99m, 1));
        order1.AddProduct(new Product("Gluten-Free Bread", "CTR8", 2.49m, 2));
        order1.AddProduct(new Product("Water Bottle", "W4TR", 1.49m, 3));

        Console.WriteLine("\nOrder 1:\n");
        order1.DisplayOrder();

        Address address2 = new Address("1830 Restoration Rd", "Nauvoo", "IL", "USA");
        Customer customer2 = new Customer("Joseph Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Book of Mormon", "H01Y", 5.99m, 12));
        order2.AddProduct(new Product("Book of Commandments", "C0MM", 6.99m, 1));

        Console.WriteLine("\nOrder 2:\n");
        order2.DisplayOrder();
    }
}