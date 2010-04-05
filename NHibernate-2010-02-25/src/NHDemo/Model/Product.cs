namespace NHDemo.Model {
	using System;

	public class Product {
		public virtual Guid Id { get; set; }
		public virtual string Name { get; set; }
		public virtual double Price { get; set; }
	}
}