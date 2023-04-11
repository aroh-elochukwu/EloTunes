using EloTunes.Data;
using EloTunes.Models;
using Microsoft.AspNetCore.Mvc;

namespace EloTunes.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ArtistController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Artist> artistList = _db.Artists;
            return View(artistList);
        }
    }
}
