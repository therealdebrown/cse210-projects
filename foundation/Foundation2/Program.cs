using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{      
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Iron", "P001", 100.00);
            Product product2 = new Product("Smartphone", "P002", 1200.00);

            Customer customer = new Customer("Moise Fabrice", "237 Yaounde, center", "M3456");

            Order order = new Order("O001");
            order.AddProduct(product1, 1);
            order.AddProduct(product2, 2);

            Console.WriteLine(order.GenerateOrderSummary());

            Console.WriteLine(customer.GetCustomerInfo());
        }
    }
}