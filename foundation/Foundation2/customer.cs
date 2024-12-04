using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{ 
    public class Customer
    {
        private string Name;
        private Address CustomerAddress;

        public Customer(string name, Address address)
        {
            Name = name;
            CustomerAddress = address;  
        }

        public string GetCustomerInfo()
        {
            return $"Name: {Name}, Address: {CustomerAddress.GetFullAddress()}";
        }

        public string GetShippingLabel()
        {
            return $"Shipping To: {Name}, {CustomerAddress.GetFullAddress()}";
        }
    }
}