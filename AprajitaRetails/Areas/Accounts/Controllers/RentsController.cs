﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Accounts.Expenses;

namespace AprajitaRetails.Areas.Accounts.Controllers
{
    [Area("Accounts")]
    public class RentsController : Controller
    {
        private readonly AprajitaRetailsContext _context;

        public RentsController(AprajitaRetailsContext context)
        {
            _context = context;
        }

        // GET: Accounts/Rents
        public async Task<IActionResult> Index()
        {
            var aprajitaRetailsContext = _context.Rents.Include(r => r.Location).Include(r => r.Store);
            return View(await aprajitaRetailsContext.ToListAsync());
        }

        // GET: Accounts/Rents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = await _context.Rents
                .Include(r => r.Location)
                .Include(r => r.Store)
                .FirstOrDefaultAsync(m => m.RentId == id);
            if (rent == null)
            {
                return NotFound();
            }

            return View(rent);
        }

        // GET: Accounts/Rents/Create
        public IActionResult Create()
        {
            ViewData["RentedLocationId"] = new SelectList(_context.RentedLocations, "RentedLocationId", "RentedLocationId");
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId");
            return View();
        }

        // POST: Accounts/Rents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentId,RentedLocationId,RentType,OnDate,Period,Amount,Mode,PaymentDetails,Remarks,StoreId,UserId,EntryStatus,IsReadOnly")] Rent rent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RentedLocationId"] = new SelectList(_context.RentedLocations, "RentedLocationId", "RentedLocationId", rent.RentedLocationId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId", rent.StoreId);
            return View(rent);
        }

        // GET: Accounts/Rents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = await _context.Rents.FindAsync(id);
            if (rent == null)
            {
                return NotFound();
            }
            ViewData["RentedLocationId"] = new SelectList(_context.RentedLocations, "RentedLocationId", "RentedLocationId", rent.RentedLocationId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId", rent.StoreId);
            return View(rent);
        }

        // POST: Accounts/Rents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentId,RentedLocationId,RentType,OnDate,Period,Amount,Mode,PaymentDetails,Remarks,StoreId,UserId,EntryStatus,IsReadOnly")] Rent rent)
        {
            if (id != rent.RentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentExists(rent.RentId))
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
            ViewData["RentedLocationId"] = new SelectList(_context.RentedLocations, "RentedLocationId", "RentedLocationId", rent.RentedLocationId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreId", rent.StoreId);
            return View(rent);
        }

        // GET: Accounts/Rents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = await _context.Rents
                .Include(r => r.Location)
                .Include(r => r.Store)
                .FirstOrDefaultAsync(m => m.RentId == id);
            if (rent == null)
            {
                return NotFound();
            }

            return View(rent);
        }

        // POST: Accounts/Rents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rent = await _context.Rents.FindAsync(id);
            _context.Rents.Remove(rent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentExists(int id)
        {
            return _context.Rents.Any(e => e.RentId == id);
        }
    }
}
