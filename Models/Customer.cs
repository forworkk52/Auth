using System.ComponentModel.DataAnnotations;

namespace Validation_MVC.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "plz enter Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters")]
        public string Addr { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [Phone(ErrorMessage = "Invalid mobile number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$",
            ErrorMessage = "Password must be at least 8 characters long and include one letter, one number, and one special character.")]
        public string Password { get; set; }

       
        [Required(ErrorMessage = "Please Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfermPassword { get; set; }


        [AgeValidator]
        public int Age { get; set; }

        [Required(ErrorMessage = "Credit Card Number is required")]
        [CreditCard(ErrorMessage = "Invalid Credit Card number")]
        public string CreditCardNumber { get; set; }

        [Url(ErrorMessage = "Invalid URL")]
        public string Url { get; set; }
    }
}
