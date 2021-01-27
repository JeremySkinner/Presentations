using System;
using System.Collections.Generic;

namespace FVDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Discount { get; set; }
        public bool IsPreferredCustomer { get; set; }

        public List<Order> Orders { get; } = new();
        public string Email { get; set; }
    }
}