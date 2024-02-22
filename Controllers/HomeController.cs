using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_CalebHanssen.Models;
using System.Diagnostics;

namespace Mission06_CalebHanssen.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext _movieContext;
        public HomeController(MovieContext temp) // Constructor
        {
            _movieContext = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        // GET: AddMovie - Displays the form

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _movieContext.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("AddMovie"); // Assuming Movie is your model class
        }

        // POST: AddMovie - Processes the form data
        [HttpPost]
        public IActionResult AddMovie(Movie response) // Replace AddMovie with your actual model class name
        {
           _movieContext.Movies.Add(response); // Add record to the database
           _movieContext.SaveChanges(); 

            return View("Confirmation", response);

        }

        public IActionResult MovieData()
        {
            //Linq to pull data
            var collections = _movieContext.Movies.Include("Category")
                .OrderBy(x => x.Title).ToList();

            return View(collections);
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var recordToEdit = _movieContext.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _movieContext.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("AddMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedinfo) 
        {
            _movieContext.Update(updatedinfo);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieData");
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var recordToDelete = _movieContext.Movies
                .Single(x =>x.MovieId == id);

            return View(recordToDelete);
        
        }

        [HttpPost]

        public IActionResult Delete(Movie movie) 
        {
            _movieContext.Movies.Remove(movie);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieData");
        }
    }
}
