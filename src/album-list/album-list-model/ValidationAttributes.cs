using System.ComponentModel.DataAnnotations;

namespace album_list_model
{
    public class YearRangeAttribute : ValidationAttribute
    {
        private int _minYear;

        public YearRangeAttribute(int minYear)
        {
            _minYear = minYear;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is int year)
            {
                if (year >= _minYear && year <= DateTime.Now.Year)
                {
                    return ValidationResult.Success; //Effectively, 'null' means success
                }
                else
                {
                    return new ValidationResult($"Year must be between {_minYear} and {DateTime.Now.Year}.");
                }
            }

            return new ValidationResult("Invalid year format.");
        }
    }
}