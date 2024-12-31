using System.ComponentModel.DataAnnotations;

namespace Validation_MVC.Models
{
    public class AgeValidator:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is int age)
            {
                if (age % 2 != 0)
                {
                    return new ValidationResult(ErrorMessage ?? "Age must be an even number.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
