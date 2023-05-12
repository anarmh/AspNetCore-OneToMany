using FrontToBack.Data;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class ProjectDetailController : Controller
    {
        private readonly AppDbContext _context;
        public ProjectDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null) return BadRequest();
            Project project = await _context.Projects.Where(m => !m.SoftDelete).Where(m => m.Id == id).FirstOrDefaultAsync();
            if (project is null) return NotFound();

            return View(project);
        }
    }
}
