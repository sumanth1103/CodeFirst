//using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        MyContext context = new MyContext();
        ProductContext ee = new ProductContext();
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            var data = context.Users.ToList();
            foreach (var i in data)
            {
                if (i.PhoneNo.Equals(login.PhoneNo) && i.Passwor.Equals(login.Passwor))
                {
                    return View("Product", ee.Products.ToList());

                }
            }
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
    }
}