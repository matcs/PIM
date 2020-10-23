using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM.Data;
using System.Threading.Tasks;

namespace PIM.Controllers.MVC
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult News()
        {
            if (Request.Cookies["jwt"] != null)
            {
                return View();
            }
            return RedirectToAction("Unauthorized", "Error");
        }
        public IActionResult Investment()
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
        public IActionResult BuyCoin()
        {
            if (Request.Cookies["jwt"] == null)
                return RedirectToAction("Unauthorized", "Error");

            return View();
        }

        [Route("User/Profile/PaymentReceipts")]
        public IActionResult PaymentReceipts()
        {
            if (Request.Cookies["jwt"] == null)
                return RedirectToAction("Unauthorized", "Error");

            return View();
        }

        [Route("User/Profile/PaymentReceipt/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
                return NotFound();

            var paymentReceipt = await _context.PaymentReceipts
                .FirstOrDefaultAsync(m => m.PaymentReceiptsId == id);
            if (paymentReceipt == null)
                return NotFound();

            return View(paymentReceipt);
        }
    }
}
