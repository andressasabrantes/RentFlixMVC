using Microsoft.AspNetCore.Mvc;

namespace RentFlixWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
