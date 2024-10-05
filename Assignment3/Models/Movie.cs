﻿using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateOnly ReleaseDate { get; set; }
        [Display(Name = "Released By")]
        public string ReleasedBy { get; set; }
        public List<Actor> Actors { get; set; } = [];
    }
}
