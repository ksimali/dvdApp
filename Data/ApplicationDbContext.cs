using dvdApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dvdApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Dvd> Dvds { get; set; }

    public DbSet<Categorie> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Ajout des catégories directement avec HasData
        modelBuilder.Entity<Categorie>().HasData(
            new Categorie { Id = 1, Name = "Action" },
            new Categorie { Id = 2, Name = "Adolescent" },
            new Categorie { Id = 3, Name = "Biographie" },
            new Categorie { Id = 4, Name = "Cape et d'épée" },
            new Categorie { Id = 5, Name = "Catastrophe" },
            new Categorie { Id = 6, Name = "Chronique" },
            new Categorie { Id = 7, Name = "Comédie de moeurs" },
            new Categorie { Id = 8, Name = "Comédie d'horreur" },
            new Categorie { Id = 9, Name = "Comédie dramatique" },
            new Categorie { Id = 10, Name = "Comédie fantaisiste" },
            new Categorie { Id = 11, Name = "Comédie musicale" },
            new Categorie { Id = 12, Name = "Comédie policière" },
            new Categorie { Id = 13, Name = "Comédie satirique" },
            new Categorie { Id = 14, Name = "Comédie sentimentale" },
            new Categorie { Id = 15, Name = "Comédie" },
            new Categorie { Id = 16, Name = "Criminel" },
            new Categorie { Id = 17, Name = "Danse" },
            new Categorie { Id = 18, Name = "Dessins animés" },
            new Categorie { Id = 19, Name = "Documentaire" },
            new Categorie { Id = 20, Name = "Drame de guerre" },
            new Categorie { Id = 21, Name = "Drame de moeurs" },
            new Categorie { Id = 22, Name = "Drame d'horreur" },
            new Categorie { Id = 23, Name = "Drame judiciaire" },
            new Categorie { Id = 24, Name = "Drame musical" },
            new Categorie { Id = 25, Name = "Drame poétique" },
            new Categorie { Id = 26, Name = "Drame policier" },
            new Categorie { Id = 27, Name = "Drame psychologique" },
            new Categorie { Id = 28, Name = "Drame sentimental" },
            new Categorie { Id = 29, Name = "Drame social" },
            new Categorie { Id = 30, Name = "Drame" },
            new Categorie { Id = 31, Name = "Espionnage" },
            new Categorie { Id = 32, Name = "Expérimental" },
            new Categorie { Id = 33, Name = "Fantastique" },
            new Categorie { Id = 34, Name = "Film à sketches" },
            new Categorie { Id = 35, Name = "Film d'animation" },
            new Categorie { Id = 36, Name = "Film d'art martial" },
            new Categorie { Id = 37, Name = "Historique" },
            new Categorie { Id = 38, Name = "Horreur" },
            new Categorie { Id = 39, Name = "Humoristique" },
            new Categorie { Id = 40, Name = "Marionnettes" },
            new Categorie { Id = 41, Name = "Mélodrame" },
            new Categorie { Id = 42, Name = "Musical" },
            new Categorie { Id = 43, Name = "Road movie" },
            new Categorie { Id = 44, Name = "Romantique" },
            new Categorie { Id = 45, Name = "Science-fiction" },
            new Categorie { Id = 46, Name = "Série policière" },
            new Categorie { Id = 47, Name = "Série TV" },
            new Categorie { Id = 48, Name = "Spectacle d'humour" },
            new Categorie { Id = 49, Name = "Spectacle musical" },
            new Categorie { Id = 50, Name = "Suspense" },
            new Categorie { Id = 51, Name = "Western" }
        );
    }

}

