
using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
       
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.Where(m=>!m.SoftDelete).ToListAsync();
            List<Project> projects = await _context.Projects.Where(m => !m.SoftDelete).ToListAsync();
            List<Service> Services = await _context.Services.Where(m => !m.SoftDelete).ToListAsync();
            List<Feature> features = await _context.Features.Where(m => !m.SoftDelete).ToListAsync();
            List<Team> teams = await _context.Teams.Where(m => !m.SoftDelete).ToListAsync();
            List<Testimonial> testimonials = await _context.Testimonials.Where(m => !m.SoftDelete).ToListAsync();
            About about=await _context.Abouts.Where(m => !m.SoftDelete).FirstOrDefaultAsync();
            List<AboutInfos> aboutInfos = await _context.AboutInfos.Where(m => !m.SoftDelete).ToListAsync();

            HomeVM model = new()
            {
                Features = features,
                Sliders=sliders,
                Services=Services,
                Projects=projects,
                Teams=teams,
                Testimonials=testimonials,
                AboutInfos=aboutInfos,
                About=about
            };
            return View(model);
        }
        public async Task<IActionResult> ProjectDetail(int? id)
        {
            if(id == null) return BadRequest();
            Project project = await _context.Projects.Where(m => !m.SoftDelete).Where(m=>m.Id==id).FirstOrDefaultAsync();
            if(project is null) return NotFound();
            return View(project);
        }
       
    }
}