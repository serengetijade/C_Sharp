using Microsoft.AspNetCore.Mvc;

namespace TutorialFollowAlong.Controllers
{
    public class ProductsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
