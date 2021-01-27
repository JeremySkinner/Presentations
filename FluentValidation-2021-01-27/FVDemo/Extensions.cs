using System;
using FluentValidation;

namespace FVDemo
{
    public static class Extensions
    {
        public static IRuleBuilderOptions<T, DateTime> MinimumAge<T>(this IRuleBuilder<T, DateTime> rule, int minimumAge)
        {
            return rule.Must(dob => MinimumAge(dob, minimumAge))
                .WithMessage($"Must be at least {minimumAge} years old.");
        }

        private static bool MinimumAge(DateTime dateOfBirth, int minimumAge)
        {
            var now = DateTime.Today;
            int years = now.Year - dateOfBirth.Year;

            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) {
                --years;
            }

            return years >= minimumAge;
        }
    }
}