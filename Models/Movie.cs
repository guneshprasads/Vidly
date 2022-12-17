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
        
        public string Name { get; set; }

        [Display(Name = "Gener")]
        public byte GenerId { get; set; }

        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }
        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [ForeignKey("GenerId")]
        public Genre Genre { get; set; }
    }
}