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
                Console.WriteLine("Property: {0} Error Message: {1}", error.PropertyName, error.ErrorMessage);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
