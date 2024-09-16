using System;
using System.ComponentModel.DataAnnotations;

namespace dvdApp.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<Dvd>? Dvds { get; set; }

    }
}

