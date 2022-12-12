using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly_2nd_try.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte GenerId { get; set; }
        public byte NumberInStock { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        public Genre Genre { get; set; }
    }
}