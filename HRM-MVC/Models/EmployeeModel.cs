using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRM_MVC.Models {
    public class EmployeeModel {

        [Display(Name = "Employee ID")]
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid Employee Id")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give us your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give us your first name.")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "You need to give us your E-mail .")]
        public string EmailAdress { get; set; }

        [Display(Name = "Confirm E-mail")]
        [Compare("EmailAdress", ErrorMessage = "The email and confirm email must match.")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must have a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "You Need to provide a long enough password. ")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirm password do not match.")]

        public string ConfirmPassword { get; set; }

    }
}