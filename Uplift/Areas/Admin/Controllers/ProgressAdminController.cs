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
using Uplift.Utility;

namespace Uplift.Areas.Admin
{
    [Area("Admin")]
    [Authorize(Roles = SD.Admin)]
    public class ProgressAdminController : Controller
    {
        private readonly ApplicationDbContext _context;
  
        public ProgressAdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ProgressAdmin
        public async Task<IActionResult> Index(string sortOrder)
        {
            var applicationDbContext = _context.Progress.Include(p => p.IdentityUser);

            ViewBag.UserSortParm = sortOrder == "user" ? "user_desc" : "user";
            ViewBag.DateSortParm = sortOrder == "date" ? "date_desc" : "date";
            ViewBag.FlightsSortParm = sortOrder == "flights" ? "flights_desc" : "flights";
            ViewBag.StepsSortParm = sortOrder == "steps" ? "steps_desc" : "steps";
            ViewBag.DistanceSortParm = sortOrder == "distance" ? "distance_desc" : "distance";

            ViewBag.SortOrder = sortOrder;

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

        // GET: Admin/ProgressAdmin/Details/5
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

        // GET: Admin/ProgressAdmin/Create
        public IActionResult Create()
        {



            ViewData["UserId"] = new SelectList(_context.Users, "UserName", "UserName");
            return View();
        }

        // POST: Admin/ProgressAdmin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserId,CreateDate,flights,steps,distance")] progress progress)
        {
            if (ModelState.IsValid)
            {
                //User ID is initially passed as an email. This line convert to Guid string
                progress.UserId = _context.Users.FirstOrDefault(u => u.UserName == progress.UserId).Id;

                progress.ID = Guid.NewGuid();
                _context.Add(progress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", progress.UserId);
            return View(progress);
        }

        // GET: Admin/ProgressAdmin/Edit/5
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
            //ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", progress.UserId);
            var user = _context.Users.FirstOrDefault(u => u.Id == progress.UserId);
            ViewData["UserId"] = user.UserName; 

            return View(progress);
        }

        // POST: Admin/ProgressAdmin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,UserId,CreateDate,flights,steps,distance")] progress progress)
        {
            string userName = progress.UserId;
            if (id != progress.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //User ID is initially passed as an email. This line convert to Guid string
                    progress.UserId = _context.Users.FirstOrDefault(u => u.UserName == progress.UserId).Id;

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
            var user = _context.Users.FirstOrDefault(u => u.Id == progress.UserId);
            ViewData["UserId"] = userName; 
            return View(progress);
        }

        // GET: Admin/ProgressAdmin/Delete/5
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

        // POST: Admin/ProgressAdmin/Delete/5
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
