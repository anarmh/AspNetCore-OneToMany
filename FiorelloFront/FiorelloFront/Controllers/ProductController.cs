using Microsoft.AspNetCore.Mvc;

namespace FiorelloFront.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int? id)
        {
            return View();
        }
    }
}
