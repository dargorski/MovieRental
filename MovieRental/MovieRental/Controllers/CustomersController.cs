using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.Models;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class CustomersController : Controller
    {
        readonly List<Movie> _movie = new List<Movie> { new Movie { Name = "Shrek" } };
        readonly List<Customer> _customers = new List<Customer>
        {
            new Customer() {Id=1,Name = "John Smith"},
            new Customer() {Id=2,Name = "Mary Williams"}
        };


        // GET: Customers
        public ActionResult Index()
        {


            RandomMovieViewModel viewModel = new RandomMovieViewModel
            {
                Movies = _movie,
                Customers = _customers
            };



            return View(viewModel);

        }

        //Get Customers/Id
        public ActionResult Details(int id)
        {
            foreach (var customer in _customers)
            {
                if (customer.Id == id)
                    return View(customer);
            }
            return HttpNotFound();
        }

    }
}