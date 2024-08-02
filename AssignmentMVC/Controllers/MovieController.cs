using Microsoft.AspNetCore.Mvc;
using MovieProject.Models;

namespace MovieProject.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieRepository _repository;

        public MovieController()
        {
            _repository = new MovieRepository();
        }

        public IActionResult Index()
        {
            var allMovies = _repository.GetAllMovies();
            return View(allMovies);
        }

        public IActionResult Details(string name)
        {
            var movie = _repository.GetMovieByName(name);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repository.AddMovie(movie);
                return RedirectToAction("Index");
            }
            return View("Create",movie);
        }
    }
}
