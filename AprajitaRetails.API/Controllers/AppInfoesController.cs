using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models;

namespace AprajitaRetails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppInfoesController : ControllerBase
    {
        private readonly AprajitaRetailsContext _context;

        public AppInfoesController(AprajitaRetailsContext context)
        {
            _context = context;
        }

        // GET: api/AppInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppInfo>>> GetApps()
        {
            return await _context.Apps.ToListAsync();
        }

        // GET: api/AppInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppInfo>> GetAppInfo(int id)
        {
            var appInfo = await _context.Apps.FindAsync(id);

            if (appInfo == null)
            {
                return NotFound();
            }

            return appInfo;
        }

        // PUT: api/AppInfoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppInfo(int id, AppInfo appInfo)
        {
            if (id != appInfo.AppInfoId)
            {
                return BadRequest();
            }

            _context.Entry(appInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppInfoExists(id))
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

        // POST: api/AppInfoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AppInfo>> PostAppInfo(AppInfo appInfo)
        {
            _context.Apps.Add(appInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppInfo", new { id = appInfo.AppInfoId }, appInfo);
        }

        // DELETE: api/AppInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppInfo>> DeleteAppInfo(int id)
        {
            var appInfo = await _context.Apps.FindAsync(id);
            if (appInfo == null)
            {
                return NotFound();
            }

            _context.Apps.Remove(appInfo);
            await _context.SaveChangesAsync();

            return appInfo;
        }

        private bool AppInfoExists(int id)
        {
            return _context.Apps.Any(e => e.AppInfoId == id);
        }
    }
}
