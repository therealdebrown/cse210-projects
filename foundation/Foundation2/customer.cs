using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{ 
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CustomerID { get; set; }

        public Customer(string name, string address, string customerID)
        {
            Name = name;
            Address = address;
            CustomerID = customerID;
        }

        public bool ValidateDetails()
        {
            return !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Address);
        }

        public string GetCustomerInfo()
        {
            return $"Customer ID: {CustomerID}, Name: {Name}, Address: {Address}";
        }

        public void UpdateCustomerInfo(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}