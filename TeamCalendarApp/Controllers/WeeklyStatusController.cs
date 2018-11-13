using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamCalendarApp.Data;
using TeamCalendarApp.Models;

namespace TeamCalendarApp.Controllers
{
    public class WeeklyStatusController : Controller
    {
        private readonly TeamCalendarDataContext _context;

        public WeeklyStatusController(TeamCalendarDataContext context)
        {
            _context = context;
        }

        // GET: WeeklyStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.StatusItems.ToListAsync());
        }

        // GET: WeeklyStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusItem = await _context.StatusItems
                .FirstOrDefaultAsync(m => m.StatusItemId == id);
            if (statusItem == null)
            {
                return NotFound();
            }

            return View(statusItem);
        }

        // GET: WeeklyStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WeeklyStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StatusItemId,StatusTypeId,UserId,Description,DateEntered")] StatusItem statusItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statusItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statusItem);
        }

        // GET: WeeklyStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusItem = await _context.StatusItems.FindAsync(id);
            if (statusItem == null)
            {
                return NotFound();
            }
            return View(statusItem);
        }

        // POST: WeeklyStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StatusItemId,StatusTypeId,UserId,Description,DateEntered")] StatusItem statusItem)
        {
            if (id != statusItem.StatusItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statusItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusItemExists(statusItem.StatusItemId))
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
            return View(statusItem);
        }

        // GET: WeeklyStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusItem = await _context.StatusItems
                .FirstOrDefaultAsync(m => m.StatusItemId == id);
            if (statusItem == null)
            {
                return NotFound();
            }

            return View(statusItem);
        }

        // POST: WeeklyStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var statusItem = await _context.StatusItems.FindAsync(id);
            _context.StatusItems.Remove(statusItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatusItemExists(int id)
        {
            return _context.StatusItems.Any(e => e.StatusItemId == id);
        }
    }
}
