using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ModelValidationExample.CustomValidators;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationExample.Models
{
    public class Person
    {
        //[Required] 
        //[Required(ErrorMessage = "Person Name can't be empty or null")] 
        [Required(ErrorMessage = "{0} Name can't be empty or null")]
        [StringLength(40,MinimumLength =3,ErrorMessage = "{0} should be between 3 and 40 characters.")]
        [Display(Name = "Person Name")]
        //[RegularExpression("^[A-Za-z ]$",ErrorMessage = "{0} should contain only alphabets, space and dot (.)")]
        public string? PersonName { get; set; }
        [EmailAddress(ErrorMessage = "{0} should be a proper email address")]
        public string? Email { get; set; }
        //[ValidateNever]
        [Phone(ErrorMessage = "{0} should contain 10 digits")]
        public string? Phone{ get; set; } 
        [Required(ErrorMessage = "{0} can't be blank")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "{0} can't be blank")]
        [Compare("Password",ErrorMessage = "{0} and {1} donot match")]
        [Display(Name = "Re-enter Password")]
        public string? ConfirmPassword { get; set; }
        [Range(0,999.99,ErrorMessage = "{0} should be between {1} and {2}")]
        public string? Price { get; set; }
        [MinimumYearValidator(2005)]
        public DateTime? DateOfBirth { get; set; }
        public override string ToString()
        {
            return $"Person object - Person name: {this.PersonName},Email: {this.Email},Phone: {this.Phone},Password: {this.Password},Confirm Password: {this.ConfirmPassword},Price: {this.Price}";
        }

    }
}
