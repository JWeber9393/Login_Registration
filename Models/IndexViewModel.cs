using System;
using System.ComponentModel.DataAnnotations;
using login_reg.Models;

namespace login_reg.Models
{
    public class IndexViewModel
    {
        public RegUser newUser{get; set;}
        public LogUser user{get; set;}
    }
}
