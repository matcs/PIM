using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM.Data;
using PIM.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Controllers.MVC
{
    public class PaymentReceiptsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentReceiptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.PaymentReceipts.ToListAsync());
        }

        // GET: PaymentReceipts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentReceipt = await _context.PaymentReceipts
                .FirstOrDefaultAsync(m => m.PaymentReceiptsId == id);
            if (paymentReceipt == null)
            {
                return NotFound();
            }

            return View(paymentReceipt);
        }

        // GET: PaymentReceipts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentReceipts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentReceiptsId,TransactionDate,Amount,Description")] PaymentReceipt paymentReceipt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentReceipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentReceipt);
        }

        // GET: PaymentReceipts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentReceipt = await _context.PaymentReceipts.FindAsync(id);
            if (paymentReceipt == null)
            {
                return NotFound();
            }
            return View(paymentReceipt);
        }

        // POST: PaymentReceipts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PaymentReceiptsId,TransactionDate,Amount,Description")] PaymentReceipt paymentReceipt)
        {
            if (id != paymentReceipt.PaymentReceiptsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentReceipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentReceiptExists(paymentReceipt.PaymentReceiptsId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(paymentReceipt);
        }

        // GET: PaymentReceipts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentReceipt = await _context.PaymentReceipts
                .FirstOrDefaultAsync(m => m.PaymentReceiptsId == id);
            if (paymentReceipt == null)
            {
                return NotFound();
            }

            return View(paymentReceipt);
        }

        // POST: PaymentReceipts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var paymentReceipt = await _context.PaymentReceipts.FindAsync(id);
            _context.PaymentReceipts.Remove(paymentReceipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentReceiptExists(string id)
        {
            return _context.PaymentReceipts.Any(e => e.PaymentReceiptsId == id);
        }
    }
}
