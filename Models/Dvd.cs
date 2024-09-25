using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace dvdApp.Models
{
    public class Dvd
    {
        [Key]
        public int Id { get; set; }

        public string? TitreOriginal { get; set; }

        [Required(ErrorMessage = "Le titre français est obligatoire.")]
        public string? TitreFrancais { get; set; }

        public int? AnneeSortie { get; set; }

        public int CategorieId { get; set; }

        public DateTime? DerniereMiseAJour { get; set; } = DateTime.Now;  // Définit la date actuelle par défaut

        public string? MiseAJourEffectueePar { get; set; }

        public string? Supplements { get; set; } 

        public int? Duree { get; set; }

        public bool EstOriginal { get; set; }

        public string? Format { get; set; }
        
        public string? ImagePochette { get; set; }

        public string? Langue { get; set; }

        public int? NombreDisques { get; set; }

        public string? Producteur { get; set; }

        public string? Realisateur { get; set; }

        public string? ActeursPrincipaux { get; set; }

        public string? Resume { get; set; }

        public string? SousTitres { get; set; }

        public string? Proprietaire { get; set; }

        public string? Emprunteur { get; set; }

        public bool EstVersionEtendue { get; set; }

        public bool EstVisible { get; set; }

        public virtual Categorie? Categorie { get; set; }
    }
}

