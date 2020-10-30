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
    public class WorkRecordBookletsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WorkRecordBookletsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/WorkRecordBooklets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkRecordBooklet>>> GetWorkRecordBooklets()
        {
            return await _context.WorkRecordBooklets.ToListAsync();
        }

        // GET: api/WorkRecordBooklets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkRecordBooklet>> GetWorkRecordBooklet(long id)
        {
            var workRecordBooklet = await _context.WorkRecordBooklets.FindAsync(id);

            if (workRecordBooklet == null)
            {
                return NotFound();
            }

            return workRecordBooklet;
        }

        // PUT: api/WorkRecordBooklets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkRecordBooklet(long id, WorkRecordBooklet workRecordBooklet)
        {
            if (id != workRecordBooklet.WorkRecordBookletId)
            {
                return BadRequest();
            }

            _context.Entry(workRecordBooklet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkRecordBookletExists(id))
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

        // POST: api/WorkRecordBooklets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<WorkRecordBooklet>> PostWorkRecordBooklet(WorkRecordBooklet workRecordBooklet)
        {
            _context.WorkRecordBooklets.Add(workRecordBooklet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkRecordBooklet", new { id = workRecordBooklet.WorkRecordBookletId }, workRecordBooklet);
        }

        // DELETE: api/WorkRecordBooklets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WorkRecordBooklet>> DeleteWorkRecordBooklet(long id)
        {
            var workRecordBooklet = await _context.WorkRecordBooklets.FindAsync(id);
            if (workRecordBooklet == null)
            {
                return NotFound();
            }

            _context.WorkRecordBooklets.Remove(workRecordBooklet);
            await _context.SaveChangesAsync();

            return workRecordBooklet;
        }

        private bool WorkRecordBookletExists(long id)
        {
            return _context.WorkRecordBooklets.Any(e => e.WorkRecordBookletId == id);
        }
    }
}
