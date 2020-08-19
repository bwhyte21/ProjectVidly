using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ProjectVidly.Models;

namespace ProjectVidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }
        
        [Required]
        public byte GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; }
        
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}