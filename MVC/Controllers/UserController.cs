using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult News()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
