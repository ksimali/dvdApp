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

        // Seeding des DVD
        modelBuilder.Entity<Dvd>().HasData(
            new Dvd
            {
                Id = 1,
                TitreOriginal = "The Matrix",
                TitreFrancais = "La Matrice",
                AnneeSortie = 1999,
                CategorieId = 4, // Science-fiction
                Duree = 136,
                Format = "Blu-ray",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Joel Silver",
                Realisateur = "Lana Wachowski, Lilly Wachowski",
                Resume = "Un pirate informatique découvre une réalité alternative.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Cassim",
                Emprunteur = "Driss",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon1.jpg",
                ActeursPrincipaux = "Keanu Reeves, Laurence Fishburne"
            },
            new Dvd
            {
                Id = 2,
                TitreOriginal = "The Godfather",
                TitreFrancais = "Le Parrain",
                AnneeSortie = 1972,
                CategorieId = 3, // Drame
                Duree = 175,
                Format = "DVD",
                Langue = "Anglais",
                NombreDisques = 2,
                Producteur = "Albert S. Ruddy",
                Realisateur = "Francis Ford Coppola",
                Resume = "L'histoire de la famille Corleone.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Cassim",
                Emprunteur = "Driss",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon2.jpg",
                ActeursPrincipaux = "Marlon Brando, Al Pacino" 
            },
            new Dvd
            {
                Id = 3,
                TitreOriginal = "Inception",
                TitreFrancais = "Inception",
                AnneeSortie = 2010,
                CategorieId = 4, // Science-fiction
                Duree = 148,
                Format = "Blu-ray",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Emma Thomas",
                Realisateur = "Christopher Nolan",
                Resume = "Un voleur s'infiltre dans les rêves.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Cassim",
                Emprunteur = "Driss",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon3.jpg",
                ActeursPrincipaux = "Leonardo DiCaprio, Joseph Gordon-Levitt"
            },
            new Dvd
            {
                Id = 4,
                TitreOriginal = "Pulp Fiction",
                TitreFrancais = "Pulp Fiction",
                AnneeSortie = 1994,
                CategorieId = 2, // Comédie
                Duree = 154,
                Format = "DVD",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Lawrence Bender",
                Realisateur = "Quentin Tarantino",
                Resume = "Des histoires entrecroisées dans le monde du crime.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Cassim",
                Emprunteur = "Driss",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon1.jpg",
                ActeursPrincipaux = "John Travolta, Samuel L. Jackson"
            },
            new Dvd
            {
                Id = 5,
                TitreOriginal = "Titanic",
                TitreFrancais = "Titanic",
                AnneeSortie = 1997,
                CategorieId = 7, // Romantique
                Duree = 195,
                Format = "DVD",
                Langue = "Anglais",
                NombreDisques = 2,
                Producteur = "James Cameron",
                Realisateur = "James Cameron",
                Resume = "Une romance tragique à bord du Titanic.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Cassim",
                Emprunteur = "Driss",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon2.jpg",
                ActeursPrincipaux = "Leonardo DiCaprio, Kate Winslet"
            },
            new Dvd
            {
                Id = 6,
                TitreOriginal = "Star Wars: A New Hope",
                TitreFrancais = "Star Wars : Un nouvel espoir",
                AnneeSortie = 1977,
                CategorieId = 9, // Fantastique
                Duree = 121,
                Format = "Blu-ray",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Gary Kurtz",
                Realisateur = "George Lucas",
                Resume = "L'épopée galactique commence avec Luke Skywalker.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Rachid",
                Emprunteur = "Cassim",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon3.jpg",
                ActeursPrincipaux = "Mark Hamill, Harrison Ford"

            },
            // Continuez avec d'autres films pour en arriver à 60
            new Dvd
            {
                Id = 7,
                TitreOriginal = "Schindler's List",
                TitreFrancais = "La Liste de Schindler",
                AnneeSortie = 1993,
                CategorieId = 8, // Historique
                Duree = 195,
                Format = "DVD",
                Langue = "Anglais",
                NombreDisques = 2,
                Producteur = "Steven Spielberg",
                Realisateur = "Steven Spielberg",
                Resume = "L'histoire vraie d'un industriel qui sauva des centaines de Juifs pendant la Seconde Guerre mondiale.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Rachid",
                Emprunteur = "Cassim",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon1.jpg",
                ActeursPrincipaux = "Liam Neeson, Ben Kingsley"

            },
            new Dvd
            {
                Id = 8,
                TitreOriginal = "The Dark Knight",
                TitreFrancais = "Le Chevalier Noir",
                AnneeSortie = 2008,
                CategorieId = 1, // Action
                Duree = 152,
                Format = "Blu-ray",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Christopher Nolan",
                Realisateur = "Christopher Nolan",
                Resume = "Batman affronte le Joker dans un combat épique pour Gotham City.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Rachid",
                Emprunteur = "Cassim",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon2.jpg",
                ActeursPrincipaux = "Christian Bale, Heath Ledger"
            },
            new Dvd
            {
                Id = 9,
                TitreOriginal = "Gladiator",
                TitreFrancais = "Gladiator",
                AnneeSortie = 2000,
                CategorieId = 1, // Action
                Duree = 155,
                Format = "Blu-ray",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Douglas Wick",
                Realisateur = "Ridley Scott",
                Resume = "Un général romain trahi revient comme gladiateur pour se venger.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Rachid",
                Emprunteur = "Cassim",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon3.jpg",
                ActeursPrincipaux = "Russell Crowe, Joaquin Phoenix"
            },
            new Dvd
            {
                Id = 10,
                TitreOriginal = "Alien",
                TitreFrancais = "Alien",
                AnneeSortie = 1979,
                CategorieId = 5, // Horreur
                Duree = 117,
                Format = "DVD",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Walter Hill",
                Realisateur = "Ridley Scott",
                Resume = "Un équipage spatial affronte une créature extraterrestre mortelle.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Rachid",
                Emprunteur = "Cassim",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon1.jpg",
                ActeursPrincipaux = "Sigourney Weaver, Tom Skerritt"
            },

            new Dvd
            {
                Id = 11,
                TitreOriginal = "Forrest Gump",
                TitreFrancais = "Forrest Gump",
                AnneeSortie = 1994,
                CategorieId = 3, // Drame
                Duree = 142,
                Format = "DVD",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Wendy Finerman",
                Realisateur = "Robert Zemeckis",
                Resume = "La vie extraordinaire de Forrest Gump, un homme avec un faible QI.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Rachid",
                Emprunteur = "Cassim",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon2.jpg",
                ActeursPrincipaux = "Tom Hanks, Robin Wright"
            },
            new Dvd
            {
                Id = 12,
                TitreOriginal = "The Silence of the Lambs",
                TitreFrancais = "Le Silence des agneaux",
                AnneeSortie = 1991,
                CategorieId = 5, // Horreur
                Duree = 118,
                Format = "DVD",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Kenneth Utt",
                Realisateur = "Jonathan Demme",
                Resume = "Une jeune agent du FBI cherche l'aide d'un tueur en série emprisonné.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Driss",
                Emprunteur = "Rachid",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon3.jpg",
                ActeursPrincipaux = "Jodie Foster, Anthony Hopkins"
            },
            new Dvd
            {
                Id = 13,
                TitreOriginal = "The Shawshank Redemption",
                TitreFrancais = "Les Évadés",
                AnneeSortie = 1994,
                CategorieId = 3, // Drame
                Duree = 142,
                Format = "Blu-ray",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Niki Marvin",
                Realisateur = "Frank Darabont",
                Resume = "L'histoire d'un homme emprisonné qui se lie d'amitié avec un autre détenu.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Driss",
                Emprunteur = "Rachid",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon1.jpg",
                ActeursPrincipaux = "Tim Robbins, Morgan Freeman"
            },
            new Dvd
            {
                Id = 14,
                TitreOriginal = "The Lion King",
                TitreFrancais = "Le Roi Lion",
                AnneeSortie = 1994,
                CategorieId = 2, // Comédie
                Duree = 88,
                Format = "DVD",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Don Hahn",
                Realisateur = "Roger Allers, Rob Minkoff",
                Resume = "L'histoire d'un lionceau qui devient roi après la mort de son père.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Driss",
                Emprunteur = "Rachid",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon2.jpg",
                ActeursPrincipaux = "Matthew Broderick, James Earl Jones"
            },
            new Dvd
            {
                Id = 15,
                TitreOriginal = "Jurassic Park",
                TitreFrancais = "Jurassic Park",
                AnneeSortie = 1993,
                CategorieId = 1, // Action
                Duree = 127,
                Format = "DVD",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Gerald R. Molen",
                Realisateur = "Steven Spielberg",
                Resume = "Des scientifiques essaient de créer un parc avec des dinosaures vivants.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Driss",
                Emprunteur = "Rachid",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon3.jpg",
                ActeursPrincipaux = "Sam Neill, Laura Dern"
            },
            new Dvd
            {
                Id = 16,
                TitreOriginal = "La La Land",
                TitreFrancais = "La La Land",
                AnneeSortie = 2016,
                CategorieId = 7,
                Duree = 128,
                Format = "Blu-ray",
                Langue = "Anglais",
                NombreDisques = 1,
                Producteur = "Fred Berger",
                Realisateur = "Damien Chazelle",
                Resume = "Un musicien et une actrice poursuivent leurs rêves.",
                EstOriginal = true,
                EstVisible = true,
                DerniereMiseAJour = DateTime.Now,
                Proprietaire = "Driss",
                Emprunteur = "Rachid",
                MiseAJourEffectueePar = "Cassim",
                SousTitres = "Français, English",
                ImagePochette = "/img/icon1.jpg",
                ActeursPrincipaux = "Ryan Gosling, Emma Stone"
            }

            // Ajoutez encore d'autres films pour remplir la liste...
        );
    }
}

