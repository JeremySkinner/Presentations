namespace FVDemo.Models {
	using System;
	using FluentValidation;
	using FluentValidation.Validators;

	public class PersonValidator : AbstractValidator<Person> {
		public PersonValidator() {
			RuleFor(x => x.Surname).NotEmpty();
			RuleFor(x => x.Forename).NotEmpty();

			RuleFor(x => x.Surname).NotEqual(x => x.Forename);

			RuleFor(x => x.Discount).GreaterThanOrEqualTo(0)
				.When(x => x.IsPreferredCustomer);

			RuleFor(x => x.Email).EmailAddress();
			RuleFor(x => x.DateOfBirth)
				.NotEqual(default(DateTime))
				.Must(BeOver18).WithMessage("Must be over 18 years old");
		}

		bool BeOver18(DateTime dateOfBirth) {
			var now = DateTime.Today; 
			int years = now.Year - dateOfBirth.Year;

			if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) {
				--years;
			}

			return years >= 18;
		}
	}

	public class MinimumAgeValidator : PropertyValidator {
		readonly int minimumAge;

		public MinimumAgeValidator(int minimumAge) 
			: base("Must be at least {MinimumAge} years old") {
			this.minimumAge = minimumAge;
		}

		protected override bool IsValid(PropertyValidatorContext context) {
			var dateOfBirth = (DateTime)context.PropertyValue;

			var now = DateTime.Today;
			int years = now.Year - dateOfBirth.Year;

			if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) {
				--years;
			}

			context.MessageFormatter.AppendArgument("MinimumAge", minimumAge);

			return years >= minimumAge;
		}
	}
}