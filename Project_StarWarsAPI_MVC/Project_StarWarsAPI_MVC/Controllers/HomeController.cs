using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_StarWarsAPI_MVC.Data;
using Project_StarWarsAPI_MVC.Models;
using Project_StarWarsAPI_MVC.Models.Content;
using Project_StarWarsAPI_MVC.Models.SWAPI_Resources;
using System.Diagnostics;

namespace Project_StarWarsAPI_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SWContext _context;

        public HomeController(ILogger<HomeController> logger, SWContext context)
        {
            _logger = logger;
            _context = context;
        }

        //Update the view to include db data
        public async Task<IActionResult> Index()
        {
            return _context.Starship != null ?
                View(await _context.Starship.ToListAsync()) :
                Problem("Entity set 'SWContext.Starship'  is null.");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}