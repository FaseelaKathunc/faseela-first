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
        //public async Task<IActionResult> Index()
        //{
        //    return _dbhelper.tbl_category!= null ?
        //       View(await _dbhelper.tbl_category.ToListAsync()) :
        //   Problem("entity set is null");
            
        //}

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
        //commented adding another function
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Index(string cat)
        //{
        //    if (cat == null)
        //    {
        //        return NotFound();
        //    }
        //    var ctgr = from c in _dbhelper.tbl_category where c.C_name == cat select c;
        //    if (ctgr == null) { return NotFound(); }
        //    return View(ctgr);

        //}
        
        //add two pageination class file
        //public async Task<IActionResult>Index(int ? pageNumber)
        //{
        //    int page_size = 2;
        //    return View(PaginatedList<Category>.
        //        Create(_dbhelper.tbl_category.ToList(),pageNumber ?? 1, page_size));
        //}
    }
}
