using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Code_First.Models;

namespace Code_First.Controllers
{
    public class DocGiaController : Controller
    {
        private readonly ThuVienContext _context;

        public DocGiaController(ThuVienContext context)
        {
            _context = context;
        }

        // GET: DocGia
        public async Task<IActionResult> Index()
        {
            return View(await _context.DocGias.ToListAsync());
        }

        // GET: DocGia/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docGia = await _context.DocGias
                .FirstOrDefaultAsync(m => m.MaDG == id);
            if (docGia == null)
            {
                return NotFound();
            }

            return View(docGia);
        }

        // GET: DocGia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DocGia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDG,TenDG,SDT")] DocGia docGia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(docGia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(docGia);
        }

        // GET: DocGia/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docGia = await _context.DocGias.FindAsync(id);
            if (docGia == null)
            {
                return NotFound();
            }
            return View(docGia);
        }

        // POST: DocGia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaDG,TenDG,SDT")] DocGia docGia)
        {
            if (id != docGia.MaDG)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(docGia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocGiaExists(docGia.MaDG))
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
            return View(docGia);
        }

        // GET: DocGia/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docGia = await _context.DocGias
                .FirstOrDefaultAsync(m => m.MaDG == id);
            if (docGia == null)
            {
                return NotFound();
            }

            return View(docGia);
        }

        // POST: DocGia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var docGia = await _context.DocGias.FindAsync(id);
            if (docGia != null)
            {
                _context.DocGias.Remove(docGia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocGiaExists(string id)
        {
            return _context.DocGias.Any(e => e.MaDG == id);
        }
    }
}
