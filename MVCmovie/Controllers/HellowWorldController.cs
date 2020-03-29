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
            TempData["message"] = "this is temp data";
            string k = "this is view bag data";
            ViewBag.product = k;
            return View();
        }

        public IActionResult pamal(int num)
        {
            ViewData["age"] = "My age is " + num;
            return View();
        } public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public IActionResult chamath()
        {
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