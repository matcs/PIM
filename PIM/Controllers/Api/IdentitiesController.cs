using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM.Data;
using PIM.Models.PersonModel;

namespace PIM.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class IdentitiesController : ControllerBase
    {
        private readonly PIMContext _context;

        public IdentitiesController(PIMContext context)
        {
            _context = context;
        }

        // GET: api/Identities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Identity>>> GetIdentities()
        {
            return await _context.Identities.ToListAsync();
        }

        // GET: api/Identities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Identity>> GetIdentity(long id)
        {
            var identity = await _context.Identities.FindAsync(id);

            if (identity == null)
            {
                return NotFound();
            }

            return identity;
        }

        // PUT: api/Identities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIdentity(long id, Identity identity)
        {
            if (id != identity.IdentityId)
            {
                return BadRequest();
            }

            _context.Entry(identity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IdentityExists(id))
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

        // POST: api/Identities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Identity>> PostIdentity(Identity identity)
        {
            _context.Identities.Add(identity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIdentity", new { id = identity.IdentityId }, identity);
        }

        // DELETE: api/Identities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Identity>> DeleteIdentity(long id)
        {
            var identity = await _context.Identities.FindAsync(id);
            if (identity == null)
            {
                return NotFound();
            }

            _context.Identities.Remove(identity);
            await _context.SaveChangesAsync();

            return identity;
        }

        private bool IdentityExists(long id)
        {
            return _context.Identities.Any(e => e.IdentityId == id);
        }
    }
}
