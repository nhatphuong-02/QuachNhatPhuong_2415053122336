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
    public class PhieuMuonController : Controller
    {
        private readonly ThuVienContext _context;

        public PhieuMuonController(ThuVienContext context)
        {
            _context = context;
        }

        // GET: PhieuMuon
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhieuMuons.ToListAsync());
        }

        // GET: PhieuMuon/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuMuon = await _context.PhieuMuons
                .FirstOrDefaultAsync(m => m.MaPM == id);
            if (phieuMuon == null)
            {
                return NotFound();
            }

            return View(phieuMuon);
        }

        // GET: PhieuMuon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PhieuMuon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaPM,MaDG,NgayMuon")] PhieuMuon phieuMuon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieuMuon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phieuMuon);
        }

        // GET: PhieuMuon/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuMuon = await _context.PhieuMuons.FindAsync(id);
            if (phieuMuon == null)
            {
                return NotFound();
            }
            return View(phieuMuon);
        }

        // POST: PhieuMuon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaPM,MaDG,NgayMuon")] PhieuMuon phieuMuon)
        {
            if (id != phieuMuon.MaPM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieuMuon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieuMuonExists(phieuMuon.MaPM))
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
            return View(phieuMuon);
        }

        // GET: PhieuMuon/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuMuon = await _context.PhieuMuons
                .FirstOrDefaultAsync(m => m.MaPM == id);
            if (phieuMuon == null)
            {
                return NotFound();
            }

            return View(phieuMuon);
        }

        // POST: PhieuMuon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var phieuMuon = await _context.PhieuMuons.FindAsync(id);
            if (phieuMuon != null)
            {
                _context.PhieuMuons.Remove(phieuMuon);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhieuMuonExists(string id)
        {
            return _context.PhieuMuons.Any(e => e.MaPM == id);
        }
    }
}
