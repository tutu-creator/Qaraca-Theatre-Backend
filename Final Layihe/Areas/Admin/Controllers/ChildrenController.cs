using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Layihe.DataAccesLayer;
using Final_Layihe.Models;

namespace Final_Layihe.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChildrenController : Controller
    {
        private readonly AppDbContext _context;

        public ChildrenController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Children
        public async Task<IActionResult> Index()
        {
            return View(await _context.Children.ToListAsync());
        }

        // GET: Admin/Children/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var children = await _context.Children
                .FirstOrDefaultAsync(m => m.Id == id);
            if (children == null)
            {
                return NotFound();
            }

            return View(children);
        }

        // GET: Admin/Children/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Children/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Image,Price")] Children children)
        {
            if (ModelState.IsValid)
            {
                _context.Add(children);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(children);
        }

        // GET: Admin/Children/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var children = await _context.Children.FindAsync(id);
            if (children == null)
            {
                return NotFound();
            }
            return View(children);
        }

        // POST: Admin/Children/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Image,Price")] Children children)
        {
            if (id != children.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(children);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChildrenExists(children.Id))
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
            return View(children);
        }

        // GET: Admin/Children/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var children = await _context.Children
                .FirstOrDefaultAsync(m => m.Id == id);
            if (children == null)
            {
                return NotFound();
            }

            return View(children);
        }

        // POST: Admin/Children/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var children = await _context.Children.FindAsync(id);
            if (children != null)
            {
                _context.Children.Remove(children);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChildrenExists(int id)
        {
            return _context.Children.Any(e => e.Id == id);
        }
    }
}
