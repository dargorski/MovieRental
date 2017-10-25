using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.Models;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class MoviesController : Controller
    {
        readonly List<Movie> _movies = new List<Movie>
        {
            new Movie { Id = 1,Name = "Shrek" },
            new Movie {Id = 2, Name = "Wall-E"}
        };
        readonly List<Customer> _customers = new List<Customer>
        {
            new Customer() {Id=1,Name = "John Smith"},
            new Customer() {Id=2,Name = "Mary Williams"}
        };
        // GET: Movies/Random
        public ActionResult Index()
        {

            RandomMovieViewModel viewModel = new RandomMovieViewModel
            {
                Movies = _movies,
                Customers = _customers
            };

            return View(viewModel);
        }

        //EDIT id = id
        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        //movies

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}