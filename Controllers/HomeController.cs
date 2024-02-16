using Microsoft.AspNetCore.Mvc;
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
        public IActionResult AddMovie()
        {
            return View(new Movie()); // Assuming Movie is your model class
        }

        // POST: AddMovie - Processes the form data
        [HttpPost]
        public ActionResult AddMovie(Movie movie) // Replace AddMovie with your actual model class name
        {
           _movieContext.Applications.Add(movie); // Add record to the database
           _movieContext.SaveChanges(); 

            return View("Confirmation", movie);

        }
    }
}
