namespace FVDemo {
	using FluentValidation;

	public class OrderValidator : AbstractValidator<Order> {
		public OrderValidator() {
			RuleFor(x => x.Amount).GreaterThan(0);
		}
		
	}
}