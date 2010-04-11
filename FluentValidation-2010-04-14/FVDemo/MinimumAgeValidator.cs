namespace FVDemo {
	using System;
	using FluentValidation.Validators;

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

	/*
	 dateOfBirth => {
					var now = DateTime.Today;
					int years = now.Year - dateOfBirth.Year;

					if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) {
						--years;
					}

					return years >= 18;
				}
	 */
}