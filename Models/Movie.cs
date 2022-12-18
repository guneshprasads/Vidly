using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly_2nd_try.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Display(Name = "Gener")]
        public byte GenerId { get; set; }

        [Required(ErrorMessage = "The number is valid between 1 and 20")]
        [Display(Name = "Number In Stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        
        [ForeignKey("GenerId")]
        public Genre Genre { get; set; }
    }
}