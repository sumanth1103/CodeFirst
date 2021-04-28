using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Login
    {
        public string PhoneNo { get; set; }
        [DataType("Password")]
        public string Passwor { get; set; }
    }
}