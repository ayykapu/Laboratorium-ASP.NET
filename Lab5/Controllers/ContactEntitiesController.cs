using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataForLab5;
using DataForLab5.Entities;

namespace Lab5.Controllers
{
    public class ContactEntitiesController : Controller
    {
        private readonly AppDbContext _context;

        public ContactEntitiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ContactEntities
        public async Task<IActionResult> Index()
        {
              return _context.ContactEntities != null ? 
                          View(await _context.ContactEntities.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.ContactEntities'  is null.");
        }

        // GET: ContactEntities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ContactEntities == null)
            {
                return NotFound();
            }

            var contactEntity = await _context.ContactEntities
                .FirstOrDefaultAsync(m => m.ContactId == id);
            if (contactEntity == null)
            {
                return NotFound();
            }

            return View(contactEntity);
        }

        // GET: ContactEntities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContactId,Name,Email,Phone,Birth")] ContactEntity contactEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactEntity);
        }

        // GET: ContactEntities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ContactEntities == null)
            {
                return NotFound();
            }

            var contactEntity = await _context.ContactEntities.FindAsync(id);
            if (contactEntity == null)
            {
                return NotFound();
            }
            return View(contactEntity);
        }

        // POST: ContactEntities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContactId,Name,Email,Phone,Birth")] ContactEntity contactEntity)
        {
            if (id != contactEntity.ContactId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactEntityExists(contactEntity.ContactId))
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
            return View(contactEntity);
        }

        // GET: ContactEntities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ContactEntities == null)
            {
                return NotFound();
            }

            var contactEntity = await _context.ContactEntities
                .FirstOrDefaultAsync(m => m.ContactId == id);
            if (contactEntity == null)
            {
                return NotFound();
            }

            return View(contactEntity);
        }

        // POST: ContactEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ContactEntities == null)
            {
                return Problem("Entity set 'AppDbContext.ContactEntities'  is null.");
            }
            var contactEntity = await _context.ContactEntities.FindAsync(id);
            if (contactEntity != null)
            {
                _context.ContactEntities.Remove(contactEntity);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactEntityExists(int id)
        {
          return (_context.ContactEntities?.Any(e => e.ContactId == id)).GetValueOrDefault();
        }
    }
}
