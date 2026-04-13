using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTLOP.Data;
using BTLOP.Models;

namespace BTLOP.Controllers
{
    public class DangKisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DangKisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DangKis
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.dk.Include(d => d.kh).Include(d => d.sv);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DangKis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangKi = await _context.dk
                .Include(d => d.kh)
                .Include(d => d.sv)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dangKi == null)
            {
                return NotFound();
            }

            return View(dangKi);
        }

        // GET: DangKis/Create
        public IActionResult Create()
        {
            ViewData["KhoaHocId"] = new SelectList(_context.kh, "Id", "Id");
            ViewData["SinhVienId"] = new SelectList(_context.sv, "Id", "Id");
            return View();
        }

        // POST: DangKis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SinhVienId,KhoaHocId")] DangKi dangKi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dangKi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KhoaHocId"] = new SelectList(_context.kh, "Id", "Id", dangKi.KhoaHocId);
            ViewData["SinhVienId"] = new SelectList(_context.sv, "Id", "Id", dangKi.SinhVienId);
            return View(dangKi);
        }

        // GET: DangKis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangKi = await _context.dk.FindAsync(id);
            if (dangKi == null)
            {
                return NotFound();
            }
            ViewData["KhoaHocId"] = new SelectList(_context.kh, "Id", "Id", dangKi.KhoaHocId);
            ViewData["SinhVienId"] = new SelectList(_context.sv, "Id", "Id", dangKi.SinhVienId);
            return View(dangKi);
        }

        // POST: DangKis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SinhVienId,KhoaHocId")] DangKi dangKi)
        {
            if (id != dangKi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dangKi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DangKiExists(dangKi.Id))
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
            ViewData["KhoaHocId"] = new SelectList(_context.kh, "Id", "Id", dangKi.KhoaHocId);
            ViewData["SinhVienId"] = new SelectList(_context.sv, "Id", "Id", dangKi.SinhVienId);
            return View(dangKi);
        }

        // GET: DangKis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangKi = await _context.dk
                .Include(d => d.kh)
                .Include(d => d.sv)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dangKi == null)
            {
                return NotFound();
            }

            return View(dangKi);
        }

        // POST: DangKis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dangKi = await _context.dk.FindAsync(id);
            if (dangKi != null)
            {
                _context.dk.Remove(dangKi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DangKiExists(int id)
        {
            return _context.dk.Any(e => e.Id == id);
        }
    }
}
