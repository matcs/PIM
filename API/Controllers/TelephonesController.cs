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
    public class TelephonesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TelephonesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Telephones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Telephone>>> GetTelephones()
        {
            return await _context.Telephones.ToListAsync();
        }

        // GET: api/Telephones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Telephone>> GetTelephone(long id)
        {
            var telephone = await _context.Telephones.FindAsync(id);

            if (telephone == null)
            {
                return NotFound();
            }

            return telephone;
        }

        // PUT: api/Telephones/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTelephone(long id, Telephone telephone)
        {
            if (id != telephone.TelephoneId)
            {
                return BadRequest();
            }

            _context.Entry(telephone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelephoneExists(id))
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

        // POST: api/Telephones
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Telephone>> PostTelephone(Telephone telephone)
        {
            _context.Telephones.Add(telephone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTelephone", new { id = telephone.TelephoneId }, telephone);
        }

        // DELETE: api/Telephones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Telephone>> DeleteTelephone(long id)
        {
            var telephone = await _context.Telephones.FindAsync(id);
            if (telephone == null)
            {
                return NotFound();
            }

            _context.Telephones.Remove(telephone);
            await _context.SaveChangesAsync();

            return telephone;
        }

        private bool TelephoneExists(long id)
        {
            return _context.Telephones.Any(e => e.TelephoneId == id);
        }
    }
}
