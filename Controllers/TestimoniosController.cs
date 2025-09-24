using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalSistemasIntegrados.Models;

namespace ProyectoFinalSistemasIntegrados.Controllers
{
    public class TestimoniosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestimoniosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Testimonios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Testimonios.ToListAsync());
        }

        // GET: Testimonios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonio = await _context.Testimonios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testimonio == null)
            {
                return NotFound();
            }

            return View(testimonio);
        }

        // GET: Testimonios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Testimonios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Mensaje")] Testimonio testimonio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testimonio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testimonio);
        }

        // GET: Testimonios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonio = await _context.Testimonios.FindAsync(id);
            if (testimonio == null)
            {
                return NotFound();
            }
            return View(testimonio);
        }

        // POST: Testimonios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Mensaje")] Testimonio testimonio)
        {
            if (id != testimonio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testimonio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestimonioExists(testimonio.Id))
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
            return View(testimonio);
        }

        // GET: Testimonios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonio = await _context.Testimonios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testimonio == null)
            {
                return NotFound();
            }

            return View(testimonio);
        }

        // POST: Testimonios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testimonio = await _context.Testimonios.FindAsync(id);
            if (testimonio != null)
            {
                _context.Testimonios.Remove(testimonio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestimonioExists(int id)
        {
            return _context.Testimonios.Any(e => e.Id == id);
        }
    }
}
