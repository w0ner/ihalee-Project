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
    public class ArabaController : Controller
    {
        private readonly ihaleeDBContext _context;

        public ArabaController(ihaleeDBContext context)
        {
            _context = context;
        }

        // GET: Araba
        public async Task<IActionResult> Listele()
        {
            return View(await _context.Arabalar.ToListAsync());
        }

        // GET: Araba/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Arabalar == null)
            {
                return NotFound();
            }

            var araba = await _context.Arabalar
                .FirstOrDefaultAsync(m => m.ArabaID == id);
            if (araba == null)
            {
                return NotFound();
            }

            return View(araba);
        }

        // GET: Araba/Create
        public IActionResult Ekle()
        {
            return View();
        }

        // POST: Araba/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle([Bind("ArabaID,AraçTipi,Marka,Model,ModelYılı,YakıtTipi,VitesTipi,MotorHacmi,Renk")] Araba araba)
        {

            _context.Add(araba);
            await _context.SaveChangesAsync();
            return RedirectToAction("Listele","Araba");


        }

        // GET: Araba/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Arabalar == null)
            {
                return NotFound();
            }

            var araba = await _context.Arabalar.FindAsync(id);
            if (araba == null)
            {
                return NotFound();
            }
            return View(araba);
        }

        // POST: Araba/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArabaID,AraçTipi,Marka,Model,ModelYılı,YakıtTipi,VitesTipi,MotorHacmi,Renk")] Araba araba)
        {
            if (id != araba.ArabaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(araba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArabaExists(araba.ArabaID))
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
            return View(araba);
        }

        // GET: Araba/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Arabalar == null)
            {
                return NotFound();
            }

            var araba = await _context.Arabalar
                .FirstOrDefaultAsync(m => m.ArabaID == id);
            if (araba == null)
            {
                return NotFound();
            }

            return View(araba);
        }

        // POST: Araba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Arabalar == null)
            {
                return Problem("Entity set 'ihaleeDBContext.Arabalar'  is null.");
            }
            var araba = await _context.Arabalar.FindAsync(id);
            if (araba != null)
            {
                _context.Arabalar.Remove(araba);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArabaExists(int id)
        {
            return _context.Arabalar.Any(e => e.ArabaID == id);
        }
    }
}
