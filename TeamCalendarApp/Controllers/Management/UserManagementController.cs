using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TeamCalendarApp.Data;
using TeamCalendarApp.Models;

namespace TeamCalendarApp.Controllers.Management
{
    public class UserManagementController : Controller
    {
        private readonly TeamCalendarDataContext _context;

        public UserManagementController(TeamCalendarDataContext context)
        {
            _context = context;
        }

        // GET: UserManagement
        public async Task<IActionResult> Index()
        {
            var user = User.Identity.Name.Split("\\")[1];
            var teamCalendarDataContext = _context.Users.Include(u => u.Department);

            return View(await teamCalendarDataContext.ToListAsync());
        }

        // GET: UserManagement/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Department)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: UserManagement/Create
        public IActionResult Create()
        {
            ViewData["Departments"] = new SelectList(_context.Departments, "DepartmentId", "Name");
            ViewData["ReportsTo"] = new SelectList(_context.Users.Where(x => x.IsManager), "UserId", "FullName");

            return View();
        }

        // POST: UserManagement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,DepartmentId,Username,FirstName,LastName,EmailAddress,IsManager,IsSiteManager,ReportsTo,UserCreated,DateCreated,UserUpdated,DateUpdated")] User user)
        {
            if (ModelState.IsValid)
            {
                user.UserCreated = User.Identity.Name.Split("\\")[1];
                user.DateCreated = DateTime.Now;
                user.UserUpdated = User.Identity.Name.Split("\\")[1];
                user.DateUpdated = DateTime.Now;

                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Departments"] = new SelectList(_context.Departments, "DepartmentId", "Name");
            ViewData["ReportsTo"] = new SelectList(_context.Users.Where(x => x.IsManager), "UserId", "FullName");

            return View(user);
        }

        // GET: UserManagement/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            ViewData["Departments"] = new SelectList(_context.Departments, "DepartmentId", "Name");
            ViewData["ReportsTo"] = new SelectList(_context.Users.Where(x => x.IsManager), "UserId", "FullName");

            return View(user);
        }

        // POST: UserManagement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,DepartmentId,Username,FirstName,LastName,EmailAddress,IsManager,IsSiteManager,ReportsTo")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.UserUpdated = User.Identity.Name.Split("\\")[1];
                    user.DateUpdated = DateTime.Now;

                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
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

            ViewData["Departments"] = new SelectList(_context.Departments, "DepartmentId", "Name");
            ViewData["ReportsTo"] = new SelectList(_context.Users.Where(x => x.IsManager), "UserId", "FullName");

            return View(user);
        }

        // GET: UserManagement/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Department)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: UserManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
