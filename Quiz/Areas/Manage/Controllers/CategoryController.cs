using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Quiz.DAL;
using Quiz.Models;

namespace Quiz.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CategoryController: Controller
    {
        readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToString());
        }
        public IActionResult Delete(int id)
        {
            using (AppDbContext context = _context)
            {
                Category category = _context.Categories.Find(id);
                if (category is null) return NotFound();
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
