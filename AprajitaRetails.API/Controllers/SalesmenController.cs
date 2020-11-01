using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Stores;

namespace AprajitaRetails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesmenController : ControllerBase
    {
        private readonly AprajitaRetailsContext _context;

        public SalesmenController(AprajitaRetailsContext context)
        {
            _context = context;
        }

        // GET: api/Salesmen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Salesman>>> GetSalesmen()
        {
            return await _context.Salesmen.ToListAsync();
        }

        // GET: api/Salesmen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Salesman>> GetSalesman(int id)
        {
            var salesman = await _context.Salesmen.FindAsync(id);

            if (salesman == null)
            {
                return NotFound();
            }

            return salesman;
        }

        // PUT: api/Salesmen/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesman(int id, Salesman salesman)
        {
            if (id != salesman.SalesmanId)
            {
                return BadRequest();
            }

            _context.Entry(salesman).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesmanExists(id))
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

        // POST: api/Salesmen
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Salesman>> PostSalesman(Salesman salesman)
        {
            _context.Salesmen.Add(salesman);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesman", new { id = salesman.SalesmanId }, salesman);
        }

        // DELETE: api/Salesmen/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Salesman>> DeleteSalesman(int id)
        {
            var salesman = await _context.Salesmen.FindAsync(id);
            if (salesman == null)
            {
                return NotFound();
            }

            _context.Salesmen.Remove(salesman);
            await _context.SaveChangesAsync();

            return salesman;
        }

        private bool SalesmanExists(int id)
        {
            return _context.Salesmen.Any(e => e.SalesmanId == id);
        }
    }
}
