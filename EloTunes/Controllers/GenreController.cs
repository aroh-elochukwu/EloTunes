using Microsoft.AspNetCore.Mvc;

namespace EloTunes.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
