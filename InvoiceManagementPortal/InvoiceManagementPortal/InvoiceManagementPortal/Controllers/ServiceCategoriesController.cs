using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InvoiceManagementPortal.Models;

namespace InvoiceManagementPortal.Controllers
{
    public class ServiceCategoriesController : Controller
    {
        private readonly InvoiceDbContext _context;

        public ServiceCategoriesController(InvoiceDbContext context)
        {
            _context = context;
        }

        // GET: ServiceCategories
        public async Task<IActionResult> Index()
        {
              return View(await _context.Services.ToListAsync());
        }

        // GET: ServiceCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var serviceCategory = await _context.Services
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceCategory == null)
            {
                return NotFound();
            }

            return View(serviceCategory);
        }

        // GET: ServiceCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] ServiceCategory serviceCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceCategory);
        }

        // GET: ServiceCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var serviceCategory = await _context.Services.FindAsync(id);
            if (serviceCategory == null)
            {
                return NotFound();
            }
            return View(serviceCategory);
        }

        // POST: ServiceCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] ServiceCategory serviceCategory)
        {
            if (id != serviceCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceCategoryExists(serviceCategory.Id))
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
            return View(serviceCategory);
        }

        // GET: ServiceCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var serviceCategory = await _context.Services
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceCategory == null)
            {
                return NotFound();
            }

            return View(serviceCategory);
        }

        // POST: ServiceCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Services == null)
            {
                return Problem("Entity set 'InvoiceDbContext.Services'  is null.");
            }
            var serviceCategory = await _context.Services.FindAsync(id);
            if (serviceCategory != null)
            {
                _context.Services.Remove(serviceCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceCategoryExists(int id)
        {
          return _context.Services.Any(e => e.Id == id);
        }
    }
}
