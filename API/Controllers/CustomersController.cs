using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM.Data;
using PIM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Customer>>> GetCustomer(string id)
        {
            var customer = await _context.Users.FindAsync(id);

            if (customer == null)
                return NotFound();

            var FullCustomerInfo = await _context.Customers
                                                .AsNoTracking()
                                                .AsQueryable()
                                                .Include(c => c.User)
                                                .Include(c => c.PaymentReceipts)
                                                .Include(c => c.Contracts)
                                                .Where(c => c.User.Id.Equals(id))
                                                .ToListAsync();

            return FullCustomerInfo;
        }

        [AllowAnonymous]
        [HttpGet("Wallet/{id}")]
        public async Task<ActionResult<List<Wallet>>> GetCustomerWallet(string id)
        {
            var customer = await _context.Users.FindAsync(id);

            if (customer == null)
                return NotFound();

            var WalletInfo = await _context.Wallets
                                           .AsNoTracking()
                                           .AsQueryable()
                                           .Where(w => w.Customer.User.Id.Equals(id))
                                           .ToListAsync();

            return WalletInfo;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(string id, Customer customer)
        {
            if (id != customer.CustumerId)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.CustumerId }, customer);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(string id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        private bool CustomerExists(string id)
        {
            return _context.Customers.Any(e => e.CustumerId == id);
        }
    }
}
