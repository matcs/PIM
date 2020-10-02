using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PIM.Controllers.MVC
{
    public class UserController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Wallet()
        {
            return View();
        }
    }
}
