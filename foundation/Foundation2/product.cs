using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductID { get; set; }
        public double Price { get; set; }

        public Product(string productName, string productID, double price)
        {
            ProductName = productName;
            ProductID = productID;
            Price = price;
        }

        public string GetProductDetails()
        {
            return $"Product ID: {ProductID}, Name: {ProductName}, Price: {Price:C}";
        }
    }
}