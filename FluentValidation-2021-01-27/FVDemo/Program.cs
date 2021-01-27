using System;

namespace FVDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var validator = new CustomerValidator();

            var result = validator.Validate(customer);

            foreach(var error in result.Errors) {
                Console.WriteLine($"Property: {error.PropertyName} Error Message: {error.ErrorMessage}");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
