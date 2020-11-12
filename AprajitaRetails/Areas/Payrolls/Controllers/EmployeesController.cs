using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Payrolls;

namespace AprajitaRetails.Areas.Payrolls.Controllers
{
    
    [Area("Payrolls")]
    public class EmployeesController : Controller
    {
        private readonly AprajitaRetailsContext _context;

        public EmployeesController(AprajitaRetailsContext context)
        {
            _context = context;
        }

        // GET: Payrolls/Employees
        public async Task<IActionResult> Index()
        {
            var aprajitaRetailsContext = _context.Employees.Include(e => e.Store);
            return View(await aprajitaRetailsContext.ToListAsync());
        }

        // GET: Payrolls/Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.Store)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return PartialView(employee);
        }

        // GET: Payrolls/Employees/Create
        public IActionResult Create()
        {
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName");
            return PartialView();
        }

        // POST: Payrolls/Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,StaffName,MobileNo,JoiningDate,LeavingDate,IsWorking,Category,IsTailors,EMail,DateOfBirth,AdharNumber,PanNo,OtherIdDetails,Address,City,State,FatherName,HighestQualification,StoreId,UserId,EntryStatus,IsReadOnly")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName", employee.StoreId);
            return PartialView(employee);
        }

        // GET: Payrolls/Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName", employee.StoreId);
            return PartialView(employee);
        }

        // POST: Payrolls/Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,StaffName,MobileNo,JoiningDate,LeavingDate,IsWorking,Category,IsTailors,EMail,DateOfBirth,AdharNumber,PanNo,OtherIdDetails,Address,City,State,FatherName,HighestQualification,StoreId,UserId,EntryStatus,IsReadOnly")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
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
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName", employee.StoreId);
            return PartialView(employee);
        }

        // GET: Payrolls/Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.Store)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return PartialView(employee);
        }

        // POST: Payrolls/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
