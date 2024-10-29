using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Multiple_layout.Data;
using Multiple_layout.Models;


namespace Multiple_layout.Controllers
{
    public class ProductController : Controller
    {
        public readonly DB_Helper _dbhelper;
        public ProductController(DB_Helper dbhelper)
        {
            _dbhelper = dbhelper;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> Index(int? pageNumber)
        {
            int pageSize = 5;

            var c = from c1 in _dbhelper.tbl_products
                    join c2 in _dbhelper.tbl_category
                  on c1.C_id equals c2.C_id
                    select new viewmodel_index
                    {
                        C_name = c2.C_name,
                        P_name = c1.P_name

                    };
          ///  return View(c.ToList());

           
            return View(await PaginatedList<viewmodel_index>.CreateAsync(c.AsNoTracking(), pageNumber ?? 1, pageSize));


        }
        public IActionResult Create()
        {
            List<Category> cl = new List<Category>();
            cl = (from c in _dbhelper.tbl_category select c).ToList();
            cl.Insert(0, new Category { C_id = 0, C_name = "---select----" });
            ViewBag.message = cl;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product p)
        {
            _dbhelper.tbl_products.Add(p);
            await _dbhelper.SaveChangesAsync();
            // return View();
            return RedirectToAction("Index");
        }

    }
    

}
