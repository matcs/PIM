using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentReceiptsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PaymentReceiptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PaymentReceipts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentReceipt>>> GetPaymentReceipts()
        {
            return await _context.PaymentReceipts.ToListAsync();
        }

        // GET: api/PaymentReceipts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentReceipt>> GetPaymentReceipt(string id)
        {
            var paymentReceipt = await _context.PaymentReceipts.FindAsync(id);

            if (paymentReceipt == null)
            {
                return NotFound();
            }

            return paymentReceipt;
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

        //TODO CHANGE THE ROUTE
        [HttpGet("By/{id}")]
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


        // PUT: api/PaymentReceipts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentReceipt(string id, PaymentReceipt paymentReceipt)
        {
            if (id != paymentReceipt.PaymentReceiptsId)
            {
                return BadRequest();
            }

            _context.Entry(paymentReceipt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentReceiptExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PaymentReceipts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PaymentReceipt>> PostPaymentReceipt(PaymentReceipt paymentReceipt)
        {
            _context.PaymentReceipts.Add(paymentReceipt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaymentReceipt", new { id = paymentReceipt.PaymentReceiptsId }, paymentReceipt);
        }

        // DELETE: api/PaymentReceipts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PaymentReceipt>> DeletePaymentReceipt(string id)
        {
            var paymentReceipt = await _context.PaymentReceipts.FindAsync(id);
            if (paymentReceipt == null)
            {
                return NotFound();
            }

            _context.PaymentReceipts.Remove(paymentReceipt);
            await _context.SaveChangesAsync();

            return paymentReceipt;
        }

        private bool PaymentReceiptExists(string id)
        {
            return _context.PaymentReceipts.Any(e => e.PaymentReceiptsId == id);
        }
    }
}
