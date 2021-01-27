using System;
using System.Collections.Generic;
using System.Linq;

namespace FVDemo.Web.Models
{
    public class CustomerData
    {
        private static List<Customer> _customers = new();

        static CustomerData()
        {
            var startDate = new DateTime(1980, 1, 1);

            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random(i);
                int random = rnd.Next(100);

                var person = new Customer
                {
                    Id = i,
                    Forename = "Customer",
                    Surname = "#" + i,
                    Email = $"Person{i}@RandomPeopleGenerator.net",
                    DateOfBirth = startDate.AddDays(i + random).AddMonths(i - random)
                };

                _customers.Add(person);
            }
        }

        public List<Customer> AllCustomers()
        {
            return _customers;
        }

        public Customer FindById(int id)
        {
            return _customers.SingleOrDefault(x => x.Id == id);
        }

        public void Save(Customer person)
        {
            if (!_customers.Contains(person))
            {
                var nextId = _customers.Max(x => x.Id) + 1;
                person.Id = nextId;
                
                _customers.Add(person);
            }
        }

        public void Delete(Customer person)
        {
            if (_customers.Contains(person))
            {
                _customers.Remove(person);
            }
        }
    }
}