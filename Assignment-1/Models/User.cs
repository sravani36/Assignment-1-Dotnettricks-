using Assignment_1.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        [MinLength(3, ErrorMessage = "Name should be atleast 3 character long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Please Enter Correct Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [MinLength(6, ErrorMessage = "Password should be atleast 6 character long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't matched")]
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }

        [RegularExpression("^[789]\\d{9}$", ErrorMessage = "Please Enter Correct Contact")]
        public string Contact { get; set; }

        [Required, Display(Name = "Country")]
        public int Country { get; set; }

        [Required, Display(Name = "City")]
        public int City { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool Terms { get; set; }
    }
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        
    }
    public partial class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
    }

}