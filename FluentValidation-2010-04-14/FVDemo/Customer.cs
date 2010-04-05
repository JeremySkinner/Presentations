namespace FVDemo {
	using System;
	using System.Collections.Generic;

	public class Customer {
		public int Id { get; set; }
		public string Surname { get; set; }
		public string Forename { get; set; }
		public DateTime DateOfBirth { get; set; }

		private List<Order> orders = new List<Order>();

		public IList<Order> Orders {
			get { return orders; }
		}

		public Customer() {
		}
	}
}