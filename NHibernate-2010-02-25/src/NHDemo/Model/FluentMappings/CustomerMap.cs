namespace NHDemo.Model.FluentMappings {
	using FluentNHibernate.Mapping;

	public class CustomerMap : ClassMap<Customer> {
		public CustomerMap() {
			Id(x => x.Id).GeneratedBy.GuidComb();
			
			Map(x => x.Name);
			Map(x => x.Company);
			Map(x => x.IsPreferredCustomer);
			Map(x => x.Discount);

			HasMany(x => x.Orders)
				.AsSet()
				.Inverse()
				.Access.ReadOnlyPropertyThroughCamelCaseField();
		}
	}
}