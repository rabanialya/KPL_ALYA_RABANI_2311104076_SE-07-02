using Microsoft.AspNetCore.Mvc;
using tjmodul9_2311104076.Models;

namespace tjmodul9_2311104076.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over a number of years."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "Batman must accept one of the greatest psychological and physical tests."
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetAllMovies()
        {
            return Ok(movies);
        }

        // GET /api/Movies/{id}
        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovieById(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound("Movie not found.");
            return Ok(movies[id]);
        }

        // POST /api/Movies
        [HttpPost]
        public ActionResult AddMovie([FromBody] Movie newMovie)
        {
            movies.Add(newMovie);
            return Ok("Movie added successfully.");
        }

        // DELETE /api/Movies/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound("Movie not found.");

            movies.RemoveAt(id);
            return Ok("Movie deleted successfully.");
        }
    }
}