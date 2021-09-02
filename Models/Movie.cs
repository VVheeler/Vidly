using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
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
        public int NumberInStock { get; set; }
    }
}