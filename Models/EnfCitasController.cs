using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EnfermeriaProyectoFinal.Models
{
    public class EnfCitasController : Controller
    {
        private readonly EnfermeriaContext _context;

        public EnfCitasController(EnfermeriaContext context)
        {
            _context = context;
        }

        // GET: EnfCitas
        public async Task<IActionResult> Index()
        {
            var enfermeriaContext = _context.EnfCitas.Include(e => e.IdHorarioNavigation).Include(e => e.IdPersonaNavigation).Include(e => e.IdProfeLlegadaNavigation).Include(e => e.IdProfeSalidaNavigation);
            return View(await enfermeriaContext.ToListAsync());
        }

        // GET: EnfCitas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfCita = await _context.EnfCitas
                .Include(e => e.IdHorarioNavigation)
                .Include(e => e.IdPersonaNavigation)
                .Include(e => e.IdProfeLlegadaNavigation)
                .Include(e => e.IdProfeSalidaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enfCita == null)
            {
                return NotFound();
            }

            return View(enfCita);
        }

        // GET: EnfCitas/Create
        public IActionResult Create()
        {
            ViewData["IdHorario"] = new SelectList(_context.EnfHorarios, "Id", "Id");
            ViewData["IdPersona"] = new SelectList(_context.EnfPersonas, "Id", "Id");
            ViewData["IdProfeLlegada"] = new SelectList(_context.EnfPersonas, "Id", "Id");
            ViewData["IdProfeSalida"] = new SelectList(_context.EnfPersonas, "Id", "Id");
            return View();
        }

        // POST: EnfCitas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPersona,IdHorario,HoraLlegada,HoraSalida,IdProfeLlegada,IdProfeSalida,MensajeLlegada,MensajeSalida,Estado,FechaCreacion,UsuarioCreacion,FechaModificacion,UsuarioModificacion")] EnfCita enfCita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enfCita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdHorario"] = new SelectList(_context.EnfHorarios, "Id", "Id", enfCita.IdHorario);
            ViewData["IdPersona"] = new SelectList(_context.EnfPersonas, "Id", "Id", enfCita.IdPersona);
            ViewData["IdProfeLlegada"] = new SelectList(_context.EnfPersonas, "Id", "Id", enfCita.IdProfeLlegada);
            ViewData["IdProfeSalida"] = new SelectList(_context.EnfPersonas, "Id", "Id", enfCita.IdProfeSalida);
            return View(enfCita);
        }

        // GET: EnfCitas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfCita = await _context.EnfCitas.FindAsync(id);
            if (enfCita == null)
            {
                return NotFound();
            }
            ViewData["IdHorario"] = new SelectList(_context.EnfHorarios, "Id", "Id", enfCita.IdHorario);
            ViewData["IdPersona"] = new SelectList(_context.EnfPersonas, "Id", "Id", enfCita.IdPersona);
            ViewData["IdProfeLlegada"] = new SelectList(_context.EnfPersonas, "Id", "Id", enfCita.IdProfeLlegada);
            ViewData["IdProfeSalida"] = new SelectList(_context.EnfPersonas, "Id", "Id", enfCita.IdProfeSalida);
            return View(enfCita);
        }

        // POST: EnfCitas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPersona,IdHorario,HoraLlegada,HoraSalida,IdProfeLlegada,IdProfeSalida,MensajeLlegada,MensajeSalida,Estado,FechaCreacion,UsuarioCreacion,FechaModificacion,UsuarioModificacion")] EnfCita enfCita)
        {
            if (id != enfCita.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enfCita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnfCitaExists(enfCita.Id))
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
            ViewData["IdHorario"] = new SelectList(_context.EnfHorarios, "Id", "Id", enfCita.IdHorario);
            ViewData["IdPersona"] = new SelectList(_context.EnfPersonas, "Id", "Id", enfCita.IdPersona);
            ViewData["IdProfeLlegada"] = new SelectList(_context.EnfPersonas, "Id", "Id", enfCita.IdProfeLlegada);
            ViewData["IdProfeSalida"] = new SelectList(_context.EnfPersonas, "Id", "Id", enfCita.IdProfeSalida);
            return View(enfCita);
        }

        // GET: EnfCitas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfCita = await _context.EnfCitas
                .Include(e => e.IdHorarioNavigation)
                .Include(e => e.IdPersonaNavigation)
                .Include(e => e.IdProfeLlegadaNavigation)
                .Include(e => e.IdProfeSalidaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enfCita == null)
            {
                return NotFound();
            }

            return View(enfCita);
        }

        // POST: EnfCitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enfCita = await _context.EnfCitas.FindAsync(id);
            if (enfCita != null)
            {
                _context.EnfCitas.Remove(enfCita);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnfCitaExists(int id)
        {
            return _context.EnfCitas.Any(e => e.Id == id);
        }
    }
}
