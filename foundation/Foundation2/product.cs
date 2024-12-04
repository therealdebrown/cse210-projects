using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{
    public class Product
    {
        private string ProductName;
        private string ProductID;
        private double Price;

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

         public double GetPrice()
        {
            return Price;
        }

        public string GetName()
        {
            return ProductName;
        }
    }
}