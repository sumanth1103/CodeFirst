using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace CodeFirst.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string PhoneNo { get; set; }
        [DataType("Password")]
        public string Passwor { get; set; }
    }



    public class MyContext : DbContext
    {
        public MyContext() : base("Data Source=PCIN490774;Initial Catalog=test;Integrated Security=True")
        {



        }
        public virtual DbSet<User> Users { get; set; }
    }




}