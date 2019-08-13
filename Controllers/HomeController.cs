using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using login_reg.Models;

namespace login_reg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("INDEX");
            Console.WriteLine("***********************************************");
            return View();
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegUser newUser)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("REGISTERING");
                Console.WriteLine(newUser.fname);
                Console.WriteLine("***********************************************");
                return RedirectToAction("Success", newUser);
            }
            else
            {
                ViewBag.Errors = ModelState.Values;
                return RedirectToAction("Index");
            }
            
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LogUser user)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("LOGGING IN");
                Console.WriteLine("***********************************************");
                return RedirectToAction("Success", user);
            }
            else
            {
                ViewBag.Errors = ModelState.Values;
                return RedirectToAction("Index");
            }
            
        }

        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("SUCCESS");
            Console.WriteLine("***********************************************");
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
