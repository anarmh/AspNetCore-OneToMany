
using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Project> projects = _context.Projects.ToList();
            List<Service> Services = _context.Services.ToList();
            List<Feature> features = _context.Features.ToList();

            HomeVM model = new()
            {
                Features = features,
                Sliders=sliders,
                Services=Services,
                Projects=projects
            };
            return View(model);
        }

       
    }
}