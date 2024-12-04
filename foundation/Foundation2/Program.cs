using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{      
    class Program
    {
        static void Main(string[] args)
        { 
        Address address1 = new Address("Street 1.004 ", "Yaounde", "Center", "Nfandena II");
            Address address2 = new Address("Street 3725", "Yaounde", "Center", "Ngoa Ekele");

            Customer customer1 = new Customer("Moise Fabrice", address1);
            Customer customer2 = new Customer("Sabastine Ndifor", address2);

            Product product1 = new Product("Smartphone", "P001", 1200.00);
            Product product2 = new Product("Smartphone", "P002", 800.00);
            Product product3 = new Product("Television", "P003", 1800.00);
            Product product4 = new Product("Earphones", "P004", 120.00);

            Order order1 = new Order("O001", customer1);
            order1.AddProduct(product1, 1);
            order1.AddProduct(product2, 2);

            Order order2 = new Order("O002", customer2);
            order2.AddProduct(product3, 1);
            order2.AddProduct(product4, 3);

            Console.WriteLine("Order 1 Summary:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}\n");

            Console.WriteLine("Order 2 Summary:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");
        }
    }
}