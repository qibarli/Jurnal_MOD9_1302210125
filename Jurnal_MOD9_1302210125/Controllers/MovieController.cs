using Microsoft.AspNetCore.Mvc;

namespace Jurnal_MOD9_1302210125.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : ControllerBase
    {
        private static List<Movie> ListMv = new List<Movie>
        {
            new Movie ("The Shawshank Redemption",
                "Frank Darabont",
                new List<string>{"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"},
                "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."),
            new Movie ("The Godfather",
                "Francis Ford Coppola",
                new List<string>{"Al Pacino", "Marlon Brando", "James Caan", "Diane Keaton"},
                "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie ("The Dark Knight",
                "Christopher Nolan",
                new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"},
                "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."),
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return ListMv;
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return ListMv[id];
        }
        [HttpPost]
        public void Post(Movie value)
        {
            ListMv.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListMv.RemoveAt(id);
        }
    }
}