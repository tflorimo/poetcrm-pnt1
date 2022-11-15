using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PoetCRM.Context;
using PoetCRM.Models;

namespace PoetCRM.Controllers
{
    public class DoctoresController : Controller
    {
        private readonly PoetCRMDatabaseContext _context;

        public DoctoresController(PoetCRMDatabaseContext context)
        {
            _context = context;
        }

        // GET: Doctores
        public async Task<IActionResult> Index()
        {
            // return View(await _context.Doctores.ToListAsync());


            //            var courses = db.Courses.Include(c => c.Department);
            //            return View(courses.ToList());
            var doctores = await _context.Doctores.Include("Especialidad").ToListAsync();
            
            return View(doctores);
        }

        // GET: Doctores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctores
                .FirstOrDefaultAsync(m => m.IdDoctor == id);
            if (doctor == null)
            {
                return NotFound();
            }

            // Teniendo al doctor encontrado, busco a través de su IdEspecialidad como FK, la PK de la especialidad que estoy buscando.
            // En la vista, accedo a ViewBag.EspecialidadDoctor.NombreEspecialidad para llegar finalmente a la descripción.
            ViewBag.EspecialidadDoctor = _context.Especialidades.Find(doctor.IdEspecialidad);
            
            return View(doctor);
        }

        // GET: Doctores/Create
        public IActionResult Create()
        {
            List<Especialidad> EspecList = _context.Especialidades.ToList();
            ViewBag.Especialidades = new SelectList(EspecList, "IdEspecialidad", "NombreEspecialidad");
            return View();
        }

        // POST: Doctores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDoctor,Nombre,Apellido,IdEspecialidad")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        // GET: Doctores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            List<Especialidad> EspecList = _context.Especialidades.ToList();
            ViewBag.Especialidades = new SelectList(EspecList, "IdEspecialidad", "NombreEspecialidad");

            var doctor = await _context.Doctores.FindAsync(id);
            
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }

        // POST: Doctores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDoctor,Nombre,Apellido,IdEspecialidad")] Doctor doctor)
        {
            if (id != doctor.IdDoctor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctor.IdDoctor))
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
            return View(doctor);
        }

        // GET: Doctores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctores
                .FirstOrDefaultAsync(m => m.IdDoctor == id);
            if (doctor == null)
            {
                return NotFound();
            }
            ViewBag.EspecialidadDoctor = _context.Especialidades.Find(doctor.IdEspecialidad);
            return View(doctor);
        }

        // POST: Doctores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor = await _context.Doctores.FindAsync(id);
            _context.Doctores.Remove(doctor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorExists(int id)
        {
            return _context.Doctores.Any(e => e.IdDoctor == id);
        }       

    }
}
