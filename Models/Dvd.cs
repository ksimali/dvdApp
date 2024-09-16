using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace dvdApp.Models
{
    public class Dvd
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Titre original")]
        public string TitreOriginal { get; set; }

        [Required]
        [Display(Name = "Titre français")]
        public string TitreFrancais { get; set; }

        [Required]
        [Display(Name = "Année de sortie")]
        public int AnneeSortie { get; set; }

        [Required]
        public int CategorieId { get; set; }

        [Display(Name = "Dernière mise à jour")]
        public DateTime DerniereMiseAJour { get; set; }

        [Display(Name = "Dernière mise à jour effectuée par")]
        public string MiseAJourEffectueePar { get; set; }

        [Display(Name = "Suppléments disponibles")]
        public List<string> Supplements { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La durée doit être supérieure à 0 minute.")]
        [Display(Name = "Durée (en minutes)")]
        public int Duree { get; set; }

        [Display(Name = "DVD original ?")]
        public bool EstOriginal { get; set; }

        [Required]
        [Display(Name = "Format")]
        public string Format { get; set; }

        [Display(Name = "Image de la pochette")]
        public string ImagePochette { get; set; }

        [Required]
        [Display(Name = "Langue")]
        public string Langue { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Le nombre de disques doit être supérieur à 0.")]
        [Display(Name = "Nombre de disques")]
        public int NombreDisques { get; set; }

        [Display(Name = "Nom du producteur")]
        public string Producteur { get; set; }

        [Display(Name = "Nom du réalisateur")]
        public string Realisateur { get; set; }

        [Display(Name = "Acteurs principaux")]
        public List<string> ActeursPrincipaux { get; set; }

        [Required]
        [Display(Name = "Résumé du film")]
        public string Resume { get; set; }

        [Display(Name = "Sous-titres")]
        public string SousTitres { get; set; }

        [Display(Name = "Propriétaire")]
        public string Propriétaire { get; set; }

        [Display(Name = "Emprunteur")]
        public string Emprunteur { get; set; }

        [Display(Name = "Version étendue ?")]
        public bool EstVersionEtendue { get; set; }

        [Display(Name = "Visible à tous ?")]
        public bool EstVisible { get; set; }

        public virtual Categorie? Categorie { get; set; }
    }
}

