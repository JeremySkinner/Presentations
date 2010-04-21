namespace GridDemo.Models {
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class CustomerRepository {
		static List<Customer> customers = new List<Customer>();

		static CustomerRepository() {
			var rand = new Random();
			for(int i = 1; i < 100; i++) {
				customers.Add(new Customer() {
				                             	Id = i,
												DateOfBirth = new DateTime(1980, 1, 1).AddDays(rand.Next(2000)),
												Name = "Customer #" + i
				                             });
			}
		}

		public IEnumerable<Customer> FindAll() {
			return customers;
		}

		public Customer FindById(int id) {
			return customers.SingleOrDefault(x => x.Id == id);
		}
	}
}