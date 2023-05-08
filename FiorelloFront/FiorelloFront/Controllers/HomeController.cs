
using FiorelloFront.Data;
using FiorelloFront.Models;
using FiorelloFront.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace FiorelloFront.Controllers
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
           IEnumerable<Slider> sliders=await _context.Sliders.Where(m=>!m.SoftDelete).ToListAsync();
            SliderInfo sliderInfo= await _context.SliderInfos.Where(m=>!m.SoftDelete).FirstOrDefaultAsync();
            IEnumerable<Blog> blogs=await _context.Blogs.Where(m => !m.SoftDelete).OrderByDescending(m=>m.Id).Take(3).ToListAsync();
            IEnumerable<Category> categories=await _context.Categories.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Product> products = await _context.Products.Include(m=>m.ProductImages).Where(m => !m.SoftDelete).ToListAsync();
           


            HomeVM model = new()
            {
                SliderInfo = sliderInfo,
                Sliders = sliders,
                Blogs=blogs,
                Categories= categories,
                Products= products,
               
            };

            return View(model);
        }

       
    }
}