using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{     
    public class Order
    {
        public string OrderID { get; set; }
        public Dictionary<Product, int> ProductQuantities { get; private set; } = new Dictionary<Product, int>();

        public Order(string orderID)
        {
            OrderID = orderID;
        }

        public void AddProduct(Product product, int quantity)
        {
            if (ProductQuantities.ContainsKey(product))
            {
                ProductQuantities[product] += quantity;
            }
            else
            {
                ProductQuantities[product] = quantity;
            }
        }

        public void RemoveProduct(Product product)
        {
            if (ProductQuantities.ContainsKey(product))
            {
                ProductQuantities.Remove(product);
            }
        }

        public double CalculateTotalCost()
        {
            double total = 0;
            foreach (var item in ProductQuantities)
            {
                total += item.Key.Price * item.Value;
            }
            return total;
        }

        public string GenerateOrderSummary()
        {
            string summary = $"Order ID: {OrderID}\n";
            foreach (var item in ProductQuantities)
            {
                summary += $"{item.Key.ProductName} (x{item.Value}) - {item.Key.Price * item.Value:C}\n";
            }
            summary += $"Total Cost: {CalculateTotalCost():C}\n";
            return summary;
        }
    }
}