﻿using System.ComponentModel.DataAnnotations;

namespace WebTestDB.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Gener { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
    }
}
