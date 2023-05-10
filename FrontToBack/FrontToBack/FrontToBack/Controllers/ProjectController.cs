using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
