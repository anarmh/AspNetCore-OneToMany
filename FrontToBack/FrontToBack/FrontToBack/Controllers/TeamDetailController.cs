using FrontToBack.Data;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class TeamDetailController : Controller
    {
        private readonly AppDbContext _context;
        public TeamDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null) return BadRequest();
            Team team = await _context.Teams.Where(m => !m.SoftDelete).FirstOrDefaultAsync(team=> team.Id == id);
            if (team is null) return NotFound();

            return View(team);
        }
    }
}
