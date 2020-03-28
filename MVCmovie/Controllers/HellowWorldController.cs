using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCmovie.Controllers
{
    public class HellowWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult pamal()
        {
            return View();
        }
        public IActionResult chamath()
        {
            return View();
        }

        public IActionResult welcome(string name,int num)
        {
            ViewData["message"] = "Hellow" + name;
            ViewData["age"] = "My age is " + num;

            return View();
        }



        //public string pamal()
        //{
        //    return "My name is pamal";
        //}

        public string sahan()
        {
            return "My name is sahan";
        }

        //public string chamath(string id ,string name)
        //{
        //    return "My age is "+id +"and my name is "+name;
        //}

    }
}