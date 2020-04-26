using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uplift.DataAccess.Data;
using Uplift.Models;
using Uplift.Utility;

namespace Uplift.Areas.Customer
{
    [Area("Customer")]
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customer/Contact
        [Authorize(Roles = SD.Admin)]
        public async Task<IActionResult> Index(string sortOrder)
        {
            var applicationDbContext = _context.Contact;

            ViewBag.EmailSortParm = sortOrder == "email" ? "email_desc" : "email";
            ViewBag.DateSortParm = sortOrder == "date" ? "date_desc" : "date";
            ViewBag.NameSortParm = sortOrder == "name" ? "name_desc" : "name";
            ViewBag.RatingSortParm = sortOrder == "rating" ? "rating_desc" : "rating";


            ViewBag.SortOrder = sortOrder;

            var entries = from p in applicationDbContext
                          select p;

            double count = 0;
            double sum = 0;
            foreach (var e in entries) {
                sum += e.Rating;
                count++;
            }
            ViewBag.Average = Math.Round(sum / count, 2);
            ViewBag.Count = count;

            switch (sortOrder)
            {
                case "email":
                    entries = entries.OrderBy(s => s.Email);
                    break;
                case "email_desc":
                    entries = entries.OrderByDescending(s => s.Email);
                    break;
                case "date":
                    entries = entries.OrderBy(s => s.CreateDate);
                    break;
                case "date_desc":
                    entries = entries.OrderByDescending(s => s.CreateDate);
                    break;
                case "rating":
                    entries = entries.OrderBy(s => s.Rating);
                    break;
                case "rating_desc":
                    entries = entries.OrderByDescending(s => s.Rating);
                    break;
                case "name":
                    entries = entries.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    entries = entries.OrderByDescending(s => s.Name);
                    break;
                default:
                    entries = entries.OrderByDescending(s => s.CreateDate);
                    break;
            }


            return View(await entries.ToListAsync());
        }

        // GET: Customer/Contact/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Customer/Contact/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CreateDate,Email,Name,Rating,Comment")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.ID = Guid.NewGuid();
                contact.CreateDate = DateTime.Now;
                _context.Add(contact);
                await _context.SaveChangesAsync();
                ViewData["alert"] = "Comment submitted. Thank you!";
            }
            return View(contact);
        }

        // GET: Customer/Contact/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // POST: Customer/Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,CreateDate,Email,Name,Rating,Comment")] Contact contact)
        {
            if (id != contact.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.ID))
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
            return View(contact);
        }

        // GET: Customer/Contact/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Customer/Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var contact = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(Guid id)
        {
            return _context.Contact.Any(e => e.ID == id);
        }
    }
}
