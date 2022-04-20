using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAsa.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult FeverCheck(float temp)
        {
            if (temp != 0)
            {
                ViewBag.Msg = Models.FeverTemp.TestForFever(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Pls enter your temperaure and then hit Submit";
                return View();
            }
        }
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

    }
}
