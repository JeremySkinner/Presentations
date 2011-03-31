namespace FVDemo.Models {
	using System;
	using System.ComponentModel.DataAnnotations;
    using FluentValidation.Attributes;

    //[Validator(typeof(PersonValidator))]
	public class Person {
		[ScaffoldColumn(false)]
		public int Id { get; set; }
		public string Email { get; set; }
		public string Surname { get; set; }
		public string Forename { get; set; }

		public int Discount { get; set; }
		public bool IsPreferredCustomer { get; set; }

		public DateTime DateOfBirth { get; set; }

		public Address Address { get; set; }
	}
}