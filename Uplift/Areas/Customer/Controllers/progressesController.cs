using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uplift.DataAccess.Data;
using Uplift.Models;

namespace Uplift.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class progressesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public progressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customer/progresses
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Progress.Include(p => p.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Customer/progresses/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progress = await _context.Progress
                .Include(p => p.IdentityUser)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (progress == null)
            {
                return NotFound();
            }

            return View(progress);
        }

        // GET: Customer/progresses/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Customer/progresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserId,flights,steps,distance")] progress progress)
        {
            if (ModelState.IsValid)
            {
                progress.ID = Guid.NewGuid();
                _context.Add(progress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", progress.UserId);
            return View(progress);
        }

        // GET: Customer/progresses/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progress = await _context.Progress.FindAsync(id);
            if (progress == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", progress.UserId);
            return View(progress);
        }

        // POST: Customer/progresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,UserId,flights,steps,distance")] progress progress)
        {
            if (id != progress.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(progress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!progressExists(progress.ID))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", progress.UserId);
            return View(progress);
        }

        // GET: Customer/progresses/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var progress = await _context.Progress
                .Include(p => p.IdentityUser)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (progress == null)
            {
                return NotFound();
            }

            return View(progress);
        }

        // POST: Customer/progresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var progress = await _context.Progress.FindAsync(id);
            _context.Progress.Remove(progress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool progressExists(Guid id)
        {
            return _context.Progress.Any(e => e.ID == id);
        }
    }
}
