using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Stores;

namespace AprajitaRetails.Areas.Stores.Controllers
{
    [Area("Stores")]
    public class EndOfDaysController : Controller
    {
        private readonly AprajitaRetailsContext _context;

        public EndOfDaysController(AprajitaRetailsContext context)
        {
            _context = context;
        }

        // GET: Stores/EndOfDays
        public async Task<IActionResult> Index()
        {
            var aprajitaRetailsContext = _context.EndOfDays.Include(e => e.Store);
            return View(await aprajitaRetailsContext.ToListAsync());
        }

        // GET: Stores/EndOfDays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endOfDay = await _context.EndOfDays
                .Include(e => e.Store)
                .FirstOrDefaultAsync(m => m.EndOfDayId == id);
            if (endOfDay == null)
            {
                return NotFound();
            }

            return View(endOfDay);
        }

        // GET: Stores/EndOfDays/Create
        public IActionResult Create()
        {
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId");
            return View();
        }

        // POST: Stores/EndOfDays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EndOfDayId,EOD_Date,Shirting,Suiting,USPA,FM_Arrow,RWT,Access,CashInHand,StoreId,UserId,EntryStatus,IsReadOnly")] EndOfDay endOfDay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(endOfDay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId", endOfDay.StoreId);
            return View(endOfDay);
        }

        // GET: Stores/EndOfDays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endOfDay = await _context.EndOfDays.FindAsync(id);
            if (endOfDay == null)
            {
                return NotFound();
            }
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId", endOfDay.StoreId);
            return View(endOfDay);
        }

        // POST: Stores/EndOfDays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EndOfDayId,EOD_Date,Shirting,Suiting,USPA,FM_Arrow,RWT,Access,CashInHand,StoreId,UserId,EntryStatus,IsReadOnly")] EndOfDay endOfDay)
        {
            if (id != endOfDay.EndOfDayId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(endOfDay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EndOfDayExists(endOfDay.EndOfDayId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId", endOfDay.StoreId);
            return View(endOfDay);
        }

        // GET: Stores/EndOfDays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endOfDay = await _context.EndOfDays
                .Include(e => e.Store)
                .FirstOrDefaultAsync(m => m.EndOfDayId == id);
            if (endOfDay == null)
            {
                return NotFound();
            }

            return View(endOfDay);
        }

        // POST: Stores/EndOfDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var endOfDay = await _context.EndOfDays.FindAsync(id);
            _context.EndOfDays.Remove(endOfDay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EndOfDayExists(int id)
        {
            return _context.EndOfDays.Any(e => e.EndOfDayId == id);
        }
    }
}
