using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemoApplication.Models
{
    public class EmployeeModel
    {   [Display (Name = "Employee ID")]
        [Range(100000,999999,ErrorMessage = "Enter a Valid Employee Id")]
        public int EmployeeId { get; set; }
        
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Please Enter First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailAddress")]
        [Required(ErrorMessage = "Please Enter Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "ConfirmEmail")]
        [Compare("EmailAddress",ErrorMessage ="Email Address does not match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter a Password")]
        [DataType(DataType.Password)]
        [StringLength(50,MinimumLength = 10,ErrorMessage = "Please Enter a long Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }


    }
}