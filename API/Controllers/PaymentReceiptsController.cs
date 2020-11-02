using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentReceiptsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PaymentReceiptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Details/{id}")]
        public async Task<ActionResult<PaymentReceipt>> GetPaymentReceipts(string id)
        {
            var paymentReceipt = await _context.PaymentReceipts.FindAsync(id);

            if (paymentReceipt == null)
            {
                return NotFound();
            }

            return paymentReceipt;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<PaymentReceipt>>> GetPaymentReceiptsByCustumer(string id)
        {
            var paymentReceipt = await _context.PaymentReceipts
                                               .Where(c => c.Customer.UserId.Equals(id))
                                               .ToListAsync();

            if (paymentReceipt == null)
            {
                return NotFound();
            }

            return paymentReceipt;
        }
        
        [HttpPost]
        public async Task<ActionResult<PaymentReceipt>> PostPaymentReceipt(PaymentReceipt paymentReceipt)
        {
            _context.PaymentReceipts.Add(paymentReceipt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaymentReceipt", new { id = paymentReceipt.PaymentReceiptsId }, paymentReceipt);
        }
    }
}
