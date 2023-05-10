using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
