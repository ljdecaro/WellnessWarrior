using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uplift.DataAccess.Data;
using Uplift.Models;

namespace Uplift.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class progressesController : Controller
    {


        private readonly ApplicationDbContext _context;

        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;

        public progressesController(ApplicationDbContext context,
        UserManager<IdentityUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

    //    public progressesController(ApplicationDbContext context)
    //{
    //    _context = context;
    //}

    // GET: Customer/progresses
    public async Task<IActionResult> Index(string sortOrder, bool social, bool admin)
        {
            var applicationDbContext = _context.Progress.Include(p => p.IdentityUser);

            ViewBag.UserSortParm = sortOrder == "user"? "user_desc" : "user";
            ViewBag.DateSortParm = sortOrder == "date" ? "date_desc" : "date";
            ViewBag.FlightsSortParm = sortOrder == "flights" ? "flights_desc" : "flights";
            ViewBag.StepsSortParm = sortOrder == "steps" ? "steps_desc" : "steps";
            ViewBag.DistanceSortParm = sortOrder == "distance" ? "distance_desc" : "distance";

            ViewBag.Social = social;
            ViewBag.Admin = admin;

            var entries = from p in applicationDbContext
                           select p;
            switch (sortOrder)
            {
                case "user":
                    entries = entries.OrderBy(s => s.IdentityUser.Email);
                    break;
                case "user_desc":
                    entries = entries.OrderByDescending(s => s.IdentityUser.Email);
                    break;
                case "date":
                    entries = entries.OrderBy(s => s.CreateDate);
                    break;
                case "date_desc":
                    entries = entries.OrderByDescending(s => s.CreateDate);
                    break;
                case "flights":
                    entries = entries.OrderBy(s => s.flights);
                    break;
                case "flights_desc":
                    entries = entries.OrderByDescending(s => s.flights);
                    break;
                case "steps":
                    entries = entries.OrderBy(s => s.steps);
                    break;
                case "steps_desc":
                    entries = entries.OrderByDescending(s => s.steps);
                    break;
                case "distance":
                    entries = entries.OrderBy(s => s.distance);
                    break;
                case "distance_desc":
                    entries = entries.OrderByDescending(s => s.distance);
                    break;
                default:
                    entries = entries.OrderByDescending(s => s.CreateDate);
                    break;
            }


            return View(await entries.ToListAsync());
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

            ViewData["UserId"] = userManager.GetUserId(HttpContext.User);
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
                progress.CreateDate = DateTime.Now;
                _context.Add(progress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = "123";
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
