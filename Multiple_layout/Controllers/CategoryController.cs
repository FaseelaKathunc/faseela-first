using Microsoft.AspNetCore.Mvc;
using Multiple_layout.Models;
using Multiple_layout.Data;
using Microsoft.EntityFrameworkCore;

namespace Multiple_layout.Controllers
{
    public class CategoryController : Controller
    {
        public readonly DB_Helper _dbhelper;
        public CategoryController(DB_Helper dbhelper)
        {
            _dbhelper = dbhelper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> category_create(Category c)
        {
            _dbhelper.tbl_category.Add(c);  
            await _dbhelper.SaveChangesAsync();
            return RedirectToAction("CategoryCreate");

        }
    }
}
