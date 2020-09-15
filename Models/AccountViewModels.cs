using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using CompareAttribute = System.Web.Mvc.CompareAttribute;

namespace POne.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class Religions
    {
        [Key]
        [Display(Name ="ReligionId")]
        public int ReligionId { get; set; }

        [Required]
        [Display(Name = "ReligionName")]
        public string ReligionName { get; set; }
    }

    public class Countries1
    {
        [Key]
        [Display(Name = "CountryId")]
        public int CountryId { set; get; }

        [Required]
        [Display(Name = "CountryName")]
        public string CountryName { set; get; }
    }

    public class People_informs
    {
        [Display(Name = "UserId")]
        public string UserId { set; get; }

        [Required]
        [Display(Name = "FullName")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string FullName { set; get; }

        [Required]
        [Display(Name = "City")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string City { set; get; }

        [Required]
        [Display(Name = "Car")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Car { set; get; }

        [Required]
        [Display(Name = "Age")]
        public int Age { set; get; }

        [Key]
        [Required]
        [Display(Name = "InfoId")]
        public int InfoId { set; get; }

        [Display(Name = "genderNum")]
        public Gender genderNum { set; get; }
        //public IEnumerable<SelectListItem> Genders { set; get; }

        //[Required]
        [Display(Name = "gender")]
        public string gender { set; get; }

        //[Required]
        //[Display(Name = "Role")]
        //public string Religion { set; get; }
        //public IEnumerable<SelectListItem> Religionss { get; set; }
        [Display(Name = "ReligionId")]
        public int ReligionId { get; set; }

        [Display(Name = "ReligionName")]
        public string ReligionName { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }

        [Display(Name = "CountryId")]
        public int CountryId { set; get; }

        [Display(Name = "CountryName")]
        public string CountryName { set; get; }
    }

    public class RegisterViewModel2
    {
        [Display(Name = "UserId")]
        public string UserId { set; get; }

        [Required]
        [Display(Name = "FullName")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string FullName { set; get; }

        [Required]
        [Display(Name = "City")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string City { set; get; }

        [Required]
        [Display(Name = "Car")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Car { set; get; }

        [Required]
        [Display(Name = "Age")]
        public int Age { set; get; }

        [Key]
        [Required]
        [Display(Name = "InfoId")]
        public int InfoId { set; get; }

        [Display(Name = "genderNum")]
        public Gender genderNum { set; get; }
        //public IEnumerable<SelectListItem> Genders { set; get; }

        //[Required]
        [Display(Name = "gender")]
        public string gender { set; get; }

        [Display(Name = "ReligionId")]
        public int ReligionId { get; set; }

        [Display(Name = "ReligionName")]
        public string ReligionName { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }

        [Display(Name = "CountryId")]
        public int CountryId { set; get; }

        [Display(Name = "CountryName")]
        public string CountryName { set; get; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
    
    public enum Gender
    {
        Male,
        Female
    }
}
