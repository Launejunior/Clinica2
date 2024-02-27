using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Clinica2.Data;
using Clinica2.Models;

namespace Clinica2.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly Clinica2Context _context;

        public ConsultasController(Clinica2Context context)
        {
            _context = context;
        }

        // GET: Consultas
        public async Task<IActionResult> Index()
        {
              return _context.Consultas != null ? 
                          View(await _context.Consultas.ToListAsync()) :
                          Problem("Entity set 'Clinica2Context.Consultas'  is null.");
        }

        // GET: Consultas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Consultas == null)
            {
                return NotFound();
            }

            var consultas = await _context.Consultas
                .FirstOrDefaultAsync(m => m.ConsultasId == id);
            if (consultas == null)
            {
                return NotFound();
            }

            return View(consultas);
        }

        // GET: Consultas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConsultasId,MedicoId,PacienteId,EspecialidadeId,HorarioId,ConvenioId,ExamesId")] Consultas consultas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consultas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consultas);
        }

        // GET: Consultas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Consultas == null)
            {
                return NotFound();
            }

            var consultas = await _context.Consultas.FindAsync(id);
            if (consultas == null)
            {
                return NotFound();
            }
            return View(consultas);
        }

        // POST: Consultas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConsultasId,MedicoId,PacienteId,EspecialidadeId,HorarioId,ConvenioId,ExamesId")] Consultas consultas)
        {
            if (id != consultas.ConsultasId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consultas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultasExists(consultas.ConsultasId))
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
            return View(consultas);
        }

        // GET: Consultas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Consultas == null)
            {
                return NotFound();
            }

            var consultas = await _context.Consultas
                .FirstOrDefaultAsync(m => m.ConsultasId == id);
            if (consultas == null)
            {
                return NotFound();
            }

            return View(consultas);
        }

        // POST: Consultas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Consultas == null)
            {
                return Problem("Entity set 'Clinica2Context.Consultas'  is null.");
            }
            var consultas = await _context.Consultas.FindAsync(id);
            if (consultas != null)
            {
                _context.Consultas.Remove(consultas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultasExists(int id)
        {
          return (_context.Consultas?.Any(e => e.ConsultasId == id)).GetValueOrDefault();
        }
    }
}
