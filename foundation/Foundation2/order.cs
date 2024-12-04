using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{     
    public class Order
    {
        private string OrderID;
        private Customer CustomerInfo;
        public Dictionary<Product, int> ProductQuantities = new Dictionary<Product, int>();

        public Order(string orderID, Customer customer)
        {
            OrderID = orderID;
            CustomerInfo = customer;
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

        public double CalculateTotalCost()
        {
            double total = 0;
            foreach (var item in ProductQuantities)
            {
                total += item.Key.GetPrice() * item.Value;
            }
            return total;
        }

        public string GetPackingLabel()
        {
            string label = $"Order ID: {OrderID}\n";
            foreach (var item in ProductQuantities)
            {
                label += $"Product: {item.Key.GetName()}, Quantity: {item.Value}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return CustomerInfo.GetShippingLabel();
        }

        public void RemoveProduct(Product product)
        {
            if (ProductQuantities.ContainsKey(product))
            {
                ProductQuantities.Remove(product);
            }
        }
    }
}