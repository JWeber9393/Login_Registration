using System;
using System.ComponentModel.DataAnnotations;

namespace login_reg.Models
{
    public class RegUser
    {
        [Required]
        [MinLength(2)]
        public string fname {get;set;}
        [Required]
        [MinLength(2)]
        public string lname {get;set;}
        [Required]
        [EmailAddress]
        public string email {get;set;}
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password {get;set;}
        [Required]
        [Compare("password")]
        [DataType(DataType.Password)]
        public string conf_pw {get;set;}
    }
}