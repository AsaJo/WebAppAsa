 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAsa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()// Get
        {
            return View();//respons
        }
        public IActionResult About()//Get
        {
            return View();//respons
        }
        public IActionResult Contact()//post
        {
            return View();//respons
        }
        public IActionResult Portfolio()//Get
        {
            return View();//respons
        }

    }
}
