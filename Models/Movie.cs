using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.ModelBinding;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [DisplayName("Genre")]
        public int GenreId { get; set; }
        [Required]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }
        [Required]
        [DisplayName("Number in Stock")]
        [Range(0, 20, ErrorMessage = "The number in stock must be between 0-20.")]
        public int NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }
    }
}