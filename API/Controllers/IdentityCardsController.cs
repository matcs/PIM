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
    public class IdentityCardsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public IdentityCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/IdentityCards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IdentityCard>>> GetIdentityCards()
        {
            return await _context.IdentityCards.ToListAsync();
        }

        // GET: api/IdentityCards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IdentityCard>> GetIdentityCard(string id)
        {
            var identityCard = await _context.IdentityCards.FindAsync(id);

            if (identityCard == null)
            {
                return NotFound();
            }

            return identityCard;
        }

        // PUT: api/IdentityCards/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIdentityCard(string id, IdentityCard identityCard)
        {
            if (id != identityCard.IdentityCardId)
            {
                return BadRequest();
            }

            _context.Entry(identityCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IdentityCardExists(id))
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

        // POST: api/IdentityCards
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<IdentityCard>> PostIdentityCard(IdentityCard identityCard)
        {
            _context.IdentityCards.Add(identityCard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIdentityCard", new { id = identityCard.IdentityCardId }, identityCard);
        }

        // DELETE: api/IdentityCards/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IdentityCard>> DeleteIdentityCard(string id)
        {
            var identityCard = await _context.IdentityCards.FindAsync(id);
            if (identityCard == null)
            {
                return NotFound();
            }

            _context.IdentityCards.Remove(identityCard);
            await _context.SaveChangesAsync();

            return identityCard;
        }

        private bool IdentityCardExists(string id)
        {
            return _context.IdentityCards.Any(e => e.IdentityCardId == id);
        }
    }
}
