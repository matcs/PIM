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
    public class CryptoCurrenciesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CryptoCurrenciesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CryptoCurrencies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CryptoCurrency>>> GetCryptoCurrencies()
        {
            return await _context.CryptoCurrencies.ToListAsync();
        }

        // GET: api/CryptoCurrencies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CryptoCurrency>> GetCryptoCurrency(long id)
        {
            var cryptoCurrency = await _context.CryptoCurrencies.FindAsync(id);

            if (cryptoCurrency == null)
            {
                return NotFound();
            }

            return cryptoCurrency;
        }

        // PUT: api/CryptoCurrencies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCryptoCurrency(long id, CryptoCurrency cryptoCurrency)
        {
            if (id != cryptoCurrency.CryptoCurrencyId)
            {
                return BadRequest();
            }

            _context.Entry(cryptoCurrency).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CryptoCurrencyExists(id))
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

        // POST: api/CryptoCurrencies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CryptoCurrency>> PostCryptoCurrency(CryptoCurrency cryptoCurrency)
        {
            _context.CryptoCurrencies.Add(cryptoCurrency);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCryptoCurrency", new { id = cryptoCurrency.CryptoCurrencyId }, cryptoCurrency);
        }

        // DELETE: api/CryptoCurrencies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CryptoCurrency>> DeleteCryptoCurrency(long id)
        {
            var cryptoCurrency = await _context.CryptoCurrencies.FindAsync(id);
            if (cryptoCurrency == null)
            {
                return NotFound();
            }

            _context.CryptoCurrencies.Remove(cryptoCurrency);
            await _context.SaveChangesAsync();

            return cryptoCurrency;
        }

        private bool CryptoCurrencyExists(long id)
        {
            return _context.CryptoCurrencies.Any(e => e.CryptoCurrencyId == id);
        }
    }
}
