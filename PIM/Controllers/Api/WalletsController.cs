﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM.Data;
using PIM.Models;

namespace PIM.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WalletsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public WalletsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Wallets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wallet>>> GetWallets()
        {
            return await _context.Wallets.ToListAsync();
        }

        // GET: api/Wallets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Wallet>> GetWallet(long id)
        {
            var wallet = await _context.Wallets.FindAsync(id);

            if (wallet == null)
            {
                return NotFound();
            }

            return wallet;
        }

        // PUT: api/Wallets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWallet(long id, Wallet wallet)
        {
            if (id != wallet.WalletId)
            {
                return BadRequest();
            }

            _context.Entry(wallet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WalletExists(id))
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

        // POST: api/Wallets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Wallet>> PostWallet(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWallet", new { id = wallet.WalletId }, wallet);
        }

        // DELETE: api/Wallets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Wallet>> DeleteWallet(long id)
        {
            var wallet = await _context.Wallets.FindAsync(id);
            if (wallet == null)
            {
                return NotFound();
            }

            _context.Wallets.Remove(wallet);
            await _context.SaveChangesAsync();

            return wallet;
        }

        private bool WalletExists(long id)
        {
            return _context.Wallets.Any(e => e.WalletId == id);
        }
    }
}
