using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ihalee.Data;
using ihalee.Models;

namespace ihalee.Controllers
{
    public class BoyamaController : Controller
    {
        private readonly ihaleeDBContext _context;

        public BoyamaController(ihaleeDBContext context)
        {
            _context = context;
        }

        // GET: Boyama
        public async Task<IActionResult> Listele()
        {
            return View(await _context.Boyamalar.ToListAsync());
        }

        // GET: Boyama/Details/5
        public async Task<IActionResult> Detay(int? id)
        {
            if (id == null || _context.Boyamalar == null)
            {
                return NotFound();
            }

            var boyama = await _context.Boyamalar
                .FirstOrDefaultAsync(m => m.BoyamaID == id);
            if (boyama == null)
            {
                return NotFound();
            }

            return View(boyama);
        }

        // GET: Boyama/Create
        public IActionResult Ekle()
        {
            return View();
        }

        // POST: Boyama/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle([Bind("BoyamaID,Renk,OdaSayisi,MetreKare,BaslamaTarihi,BoyamaNiteligi")] Boyama boyama)
        {

            _context.Add(boyama);
            await _context.SaveChangesAsync();
            return RedirectToAction("Listele","Boyama");

          
        }

        // GET: Boyama/Edit/5
        public async Task<IActionResult> Duzenle(int? id)
        {
            if (id == null || _context.Boyamalar == null)
            {
                return NotFound();
            }

            var boyama = await _context.Boyamalar.FindAsync(id);
            if (boyama == null)
            {
                return NotFound();
            }
            return View(boyama);
        }

        // POST: Boyama/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Duzenle(int id, [Bind("BoyamaID,Renk,OdaSayisi,MetreKare,BaslamaTarihi,BoyamaNiteligi")] Boyama boyama)
        {
            if (id != boyama.BoyamaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boyama);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoyamaExists(boyama.BoyamaID))
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
            return View(boyama);
        }

        // GET: Boyama/Delete/5
        public async Task<IActionResult> Sil(int? id)
        {
            if (id == null || _context.Boyamalar == null)
            {
                return NotFound();
            }

            var boyama = await _context.Boyamalar
                .FirstOrDefaultAsync(m => m.BoyamaID == id);
            if (boyama == null)
            {
                return NotFound();
            }

            return View(boyama);
        }

        // POST: Boyama/Delete/5
        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Boyamalar == null)
            {
                return Problem("Entity set 'ihaleeDBContext.Boyamalar'  is null.");
            }
            var boyama = await _context.Boyamalar.FindAsync(id);
            if (boyama != null)
            {
                _context.Boyamalar.Remove(boyama);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoyamaExists(int id)
        {
            return _context.Boyamalar.Any(e => e.BoyamaID == id);
        }
    }
}
