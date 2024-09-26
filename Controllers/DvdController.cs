using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dvdApp.Data;
using dvdApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace dvdApp.Controllers
{
    [Authorize]
    public class DvdController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public DvdController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager; // Initialisez le UserManager
        }

        // GET: Dvd
        public async Task<IActionResult> Index(string searchString, string sortOrder)
        {
            // Enregistre les paramètres de tri dans ViewData pour les conserver dans la vue
            ViewData["CurrentFilter"] = searchString;
            ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "user" : "";
            ViewData["TitleSortParam"] = sortOrder == "title" ? "title_desc" : "title";
            ViewData["UserAndTitleSortParam"] = sortOrder == "user_title" ? "user_title_desc" : "user_title";

            // Sélection initiale incluant les catégories
            var dvdsWithCategories = from d in _context.Dvds.Include(d => d.Categorie)
                                     select d;

            // Recherche par titre (français ou original)
            if (!string.IsNullOrEmpty(searchString))
            {
                dvdsWithCategories = dvdsWithCategories.Where(d =>
                    d.TitreOriginal.Contains(searchString) ||
                    d.TitreFrancais.Contains(searchString) ||
                    d.Categorie.Name.Contains(searchString));
            }

            // Tri des résultats selon les critères spécifiés
            switch (sortOrder)
            {
                case "user":
                    dvdsWithCategories = dvdsWithCategories.OrderBy(d => d.Emprunteur); // Tri par emprunteur
                    break;
                case "title":
                    dvdsWithCategories = dvdsWithCategories.OrderBy(d => d.TitreFrancais); // Tri par titre
                    break;
                case "user_title":
                    dvdsWithCategories = dvdsWithCategories
                        .OrderBy(d => d.Emprunteur)
                        .ThenBy(d => d.TitreFrancais); // Tri par emprunteur puis par titre
                    break;
                default:
                    dvdsWithCategories = dvdsWithCategories.OrderBy(d => d.TitreFrancais); // Tri par défaut par titre
                    break;
            }

            return View(await dvdsWithCategories.ToListAsync());
        }


        // GET: Dvd/DvdsEnMain
        public async Task<IActionResult> DvdsEnMain()
        {
            // Retrieve the current user
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            // Fetch DVDs owned by the logged-in user
            var dvds = await _context.Dvds
                .Where(d => d.Emprunteur == user.UserName)
                .Include(d => d.Categorie)
                .ToListAsync();

            return View(dvds);
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
                // Assigner la date de mise à jour actuelle
                dvd.DerniereMiseAJour = DateTime.Now;

                // Récupérer l'utilisateur courant (exemple utilisant l'authentification ASP.NET)
                var user = await _userManager.GetUserAsync(User);
                dvd.MiseAJourEffectueePar = user?.UserName ?? "Utilisateur inconnu";

                // Sauvegarder le DVD dans la base de données
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
