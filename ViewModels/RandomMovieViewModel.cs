using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_2nd_try.Models;

namespace Vidly_2nd_try.ViewModels
{
    public class RandomMovieViewModel
    {
        //public Movie Movie { get; set; }

        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Gener")]
        public byte GenerId { get; set; }

        [Required(ErrorMessage = "The number is valid between 1 and 20")]
        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }

        [Required]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public IEnumerable<Genre> Genre { get; set; }
        public string Title
        {
            get
            {
                return (Id != 0)?"Edit Movie":"New Movie";
            }
        }

        public RandomMovieViewModel() 
        {
            Id = 0;
        }
        public RandomMovieViewModel(Movie movie) 
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            DateAdded = movie.DateAdded;
            NumberInStock = movie.NumberInStock;
            GenerId = movie.GenerId;
        }

    }
}