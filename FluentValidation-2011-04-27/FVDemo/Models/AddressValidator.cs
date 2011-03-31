namespace FVDemo.Models {
	using FluentValidation;

	public class AddressValidator : AbstractValidator<Address> {
		public AddressValidator() {
			RuleFor(x => x.Line1).NotEmpty();
			RuleFor(x => x.Line2).NotEmpty();
			RuleFor(x => x.County).NotEmpty();

			RuleFor(x => x.Postcode)
				.NotEmpty()
				.Matches(postcodeRegex)
				.WithMessage("Please entera valid postcode");
		}

		const string postcodeRegex = "([A-PR-UWYZ0-9][A-HK-Y0-9][AEHMNPRTVXY0-9]?[ABEHMNPRVWXY0-9]? {1,2}[0-9][ABD-HJLN-UW-Z]{2}|GIR 0AA)";
	}
}