using System.Threading.Tasks;
using _931901.kuznetsov.semyon.lab2._6.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _931901.kuznetsov.semyon.lab2._6.Controllers
{
    public class MockupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MockupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllForums()
        {
            return View(await _context.ForumCategories.ToListAsync());
        }

        public IActionResult SingleForum()
        {
            return View();
        }

    }
}