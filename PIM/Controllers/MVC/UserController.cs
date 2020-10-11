using Microsoft.AspNetCore.Mvc;

namespace PIM.Controllers.MVC
{
    public class UserController : Controller
    {
        public IActionResult Dashboard()
        {
            if (Request.Cookies["jwt"] != null)
            {
                return View();
            }
            return RedirectToAction("Unauthorized", "Error");
        }

        public IActionResult News()
        {
            if (Request.Cookies["jwt"] != null)
            {
                return View();
            }
            return RedirectToAction("Unauthorized", "Error");
        }

        public IActionResult Wallet()
        {
            if (Request.Cookies["jwt"] != null)
            {
                return View();
            }
            return RedirectToAction("Unauthorized", "Error");
        }

        public IActionResult Profile()
        {
            if (Request.Cookies["jwt"] != null)
            {
                return View();
            }
            return RedirectToAction("Unauthorized", "Error");
        }
    }
}
