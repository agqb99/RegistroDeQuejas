using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroDeQuejas.Data;
using RegistroDeQuejas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroDeQuejas.Controllers
{
    public class RegistrosController : Controller
    {

        private readonly ApplicationDbContext db;
        public RegistrosController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {

            return View(await db.Registros.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro = await db.Registros.FirstOrDefaultAsync(d => d.RegistroId == id);
            if (registro == null)
            {
                return NotFound();
            }
            return View(registro);
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Registro registro)
        {
            if (ModelState.IsValid)
            {
                db.Add(registro);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registro);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro = await db.Registros.FindAsync(id);

            if (registro == null)
            {
                return NotFound();
            }

            return View(registro);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Registro registro)
        {
            if (id != registro.RegistroId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(registro);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(registro);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro = await db.Registros.FirstOrDefaultAsync(d => d.RegistroId == id);
            if (registro == null)
            {
                return NotFound();
            }

            return View(registro);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var band = await db.Registros.FindAsync(id);
            db.Registros.Remove(band);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }

}