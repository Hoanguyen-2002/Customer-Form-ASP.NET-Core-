using System.ComponentModel.DataAnnotations;

namespace Customers.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Please Enter your First Name!")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter your Last Name!")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Please Enter your Email!")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please specify whether you buy again!")]
        public bool? WillBuyAgain { get; set; }
    }
}
 