namespace NHDemo.Model {
	using System;

	public class Order {
		public virtual Guid Id { get; set; }
		public virtual DateTime OrderDate { get; set; }

		public virtual Customer Customer { get; set; }
		public virtual Product Product { get; set; }
	}
}