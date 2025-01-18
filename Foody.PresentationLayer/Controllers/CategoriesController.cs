using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
