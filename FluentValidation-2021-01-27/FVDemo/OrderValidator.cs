using FluentValidation;

namespace FVDemo
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.Amount).GreaterThan(0);
        }
    }
}