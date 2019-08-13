using System;
using System.ComponentModel.DataAnnotations;


namespace login_reg.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}