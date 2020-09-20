using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM.Data;
using PIM.Models.Administrator;

namespace PIM.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CarteiraDeTrabalhoesController : ControllerBase
    {
        private readonly PIMContext _context;

        public CarteiraDeTrabalhoesController(PIMContext context)
        {
            _context = context;
        }

        // GET: api/CarteiraDeTrabalhoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarteiraDeTrabalho>>> GetCarteiraDeTrabalhos()
        {
            return await _context.CarteiraDeTrabalhos.ToListAsync();
        }

        // GET: api/CarteiraDeTrabalhoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarteiraDeTrabalho>> GetCarteiraDeTrabalho(long id)
        {
            var carteiraDeTrabalho = await _context.CarteiraDeTrabalhos.FindAsync(id);

            if (carteiraDeTrabalho == null)
            {
                return NotFound();
            }

            return carteiraDeTrabalho;
        }

        // PUT: api/CarteiraDeTrabalhoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarteiraDeTrabalho(long id, CarteiraDeTrabalho carteiraDeTrabalho)
        {
            if (id != carteiraDeTrabalho.CarteiraDeTrabalhoId)
            {
                return BadRequest();
            }

            _context.Entry(carteiraDeTrabalho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarteiraDeTrabalhoExists(id))
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

        // POST: api/CarteiraDeTrabalhoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CarteiraDeTrabalho>> PostCarteiraDeTrabalho(CarteiraDeTrabalho carteiraDeTrabalho)
        {
            _context.CarteiraDeTrabalhos.Add(carteiraDeTrabalho);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarteiraDeTrabalho", new { id = carteiraDeTrabalho.CarteiraDeTrabalhoId }, carteiraDeTrabalho);
        }

        // DELETE: api/CarteiraDeTrabalhoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CarteiraDeTrabalho>> DeleteCarteiraDeTrabalho(long id)
        {
            var carteiraDeTrabalho = await _context.CarteiraDeTrabalhos.FindAsync(id);
            if (carteiraDeTrabalho == null)
            {
                return NotFound();
            }

            _context.CarteiraDeTrabalhos.Remove(carteiraDeTrabalho);
            await _context.SaveChangesAsync();

            return carteiraDeTrabalho;
        }

        private bool CarteiraDeTrabalhoExists(long id)
        {
            return _context.CarteiraDeTrabalhos.Any(e => e.CarteiraDeTrabalhoId == id);
        }
    }
}
