using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dvdApp.Data;
using dvdApp.Models;

namespace dvdApp.Controllers
{
    public class DvdController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DvdController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dvd
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Dvds.Include(d => d.Categorie);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Dvd/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dvd = await _context.Dvds
                .Include(d => d.Categorie)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dvd == null)
            {
                return NotFound();
            }

            return View(dvd);
        }

        // GET: Dvd/Create
        public IActionResult Create()
        {
            ViewData["CategorieId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: Dvd/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TitreOriginal,TitreFrancais,AnneeSortie,CategorieId,DerniereMiseAJour,MiseAJourEffectueePar,Supplements,Duree,EstOriginal,Format,ImagePochette,Langue,NombreDisques,Producteur,Realisateur,ActeursPrincipaux,Resume,SousTitres,Propriétaire,Emprunteur,EstVersionEtendue,EstVisible")] Dvd dvd)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dvd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategorieId"] = new SelectList(_context.Categories, "Id", "Name", dvd.CategorieId);
            return View(dvd);
        }

        // GET: Dvd/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dvd = await _context.Dvds.FindAsync(id);
            if (dvd == null)
            {
                return NotFound();
            }
            ViewData["CategorieId"] = new SelectList(_context.Categories, "Id", "Name", dvd.CategorieId);
            return View(dvd);
        }

        // POST: Dvd/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TitreOriginal,TitreFrancais,AnneeSortie,CategorieId,DerniereMiseAJour,MiseAJourEffectueePar,Supplements,Duree,EstOriginal,Format,ImagePochette,Langue,NombreDisques,Producteur,Realisateur,ActeursPrincipaux,Resume,SousTitres,Propriétaire,Emprunteur,EstVersionEtendue,EstVisible")] Dvd dvd)
        {
            if (id != dvd.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dvd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DvdExists(dvd.Id))
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
            ViewData["CategorieId"] = new SelectList(_context.Categories, "Id", "Name", dvd.CategorieId);
            return View(dvd);
        }

        // GET: Dvd/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dvd = await _context.Dvds
                .Include(d => d.Categorie)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dvd == null)
            {
                return NotFound();
            }

            return View(dvd);
        }

        // POST: Dvd/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dvd = await _context.Dvds.FindAsync(id);
            if (dvd != null)
            {
                _context.Dvds.Remove(dvd);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DvdExists(int id)
        {
            return _context.Dvds.Any(e => e.Id == id);
        }
    }
}
