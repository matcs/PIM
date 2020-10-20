using Microsoft.AspNetCore.Mvc;

namespace PIM.Controllers.MVC
{
    public class ErrorController : Controller
    {
        public IActionResult Unauthorized()
        {
            return View();
        }
    }
}
