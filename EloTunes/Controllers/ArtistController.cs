using Microsoft.AspNetCore.Mvc;

namespace EloTunes.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
