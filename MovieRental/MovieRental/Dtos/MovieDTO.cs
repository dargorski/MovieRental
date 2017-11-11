﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieRental.Models;

namespace MovieRental.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public DateTime? ReleaseDate { get; set; }
        public DateTime? AddToStockDate { get; set; }

        
        public int NumberInStock { get; set; }

        

        
        public byte GenreId { get; set; }
    }
}