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
    public class ChiTietPhieuMuonController : Controller
    {
        private readonly ThuVienContext _context;

        public ChiTietPhieuMuonController(ThuVienContext context)
        {
            _context = context;
        }

        // GET: ChiTietPhieuMuon
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChiTietPhieuMuons.ToListAsync());
        }

        // GET: ChiTietPhieuMuon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietPhieuMuon = await _context.ChiTietPhieuMuons
                .FirstOrDefaultAsync(m => m.MaCT == id);
            if (chiTietPhieuMuon == null)
            {
                return NotFound();
            }

            return View(chiTietPhieuMuon);
        }

        // GET: ChiTietPhieuMuon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChiTietPhieuMuon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaCT,MaPM,MaSach,SoLuong")] ChiTietPhieuMuon chiTietPhieuMuon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietPhieuMuon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietPhieuMuon);
        }

        // GET: ChiTietPhieuMuon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietPhieuMuon = await _context.ChiTietPhieuMuons.FindAsync(id);
            if (chiTietPhieuMuon == null)
            {
                return NotFound();
            }
            return View(chiTietPhieuMuon);
        }

        // POST: ChiTietPhieuMuon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaCT,MaPM,MaSach,SoLuong")] ChiTietPhieuMuon chiTietPhieuMuon)
        {
            if (id != chiTietPhieuMuon.MaCT)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietPhieuMuon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietPhieuMuonExists(chiTietPhieuMuon.MaCT))
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
            return View(chiTietPhieuMuon);
        }

        // GET: ChiTietPhieuMuon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietPhieuMuon = await _context.ChiTietPhieuMuons
                .FirstOrDefaultAsync(m => m.MaCT == id);
            if (chiTietPhieuMuon == null)
            {
                return NotFound();
            }

            return View(chiTietPhieuMuon);
        }

        // POST: ChiTietPhieuMuon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietPhieuMuon = await _context.ChiTietPhieuMuons.FindAsync(id);
            if (chiTietPhieuMuon != null)
            {
                _context.ChiTietPhieuMuons.Remove(chiTietPhieuMuon);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietPhieuMuonExists(int id)
        {
            return _context.ChiTietPhieuMuons.Any(e => e.MaCT == id);
        }
    }
}
