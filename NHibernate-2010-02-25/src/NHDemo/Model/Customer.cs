namespace NHDemo.Model {
	using System;
	using System.Collections.Generic;
	using Iesi.Collections.Generic;

	public class Customer {
		public virtual Guid Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Company { get; set; }
		public virtual bool IsPreferredCustomer { get; set; }
		public virtual double Discount { get; set; }

		private ISet<Order> orders = new HashedSet<Order>();

		public virtual IEnumerable<Order> Orders {
			get { return orders; }
		}

		public virtual void AddOrder(Order order) {
			order.Customer = this;
			orders.Add(order);
		}
	}
}