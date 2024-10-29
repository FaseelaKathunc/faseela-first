using Microsoft.AspNetCore.Mvc;
using Multiple_layout.Data;
using Multiple_layout.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.Xml;


namespace Multiple_layout.Controllers
{
    public class ItemController : Controller
    {
        public readonly DB_Helper _dbhelper;
        public ItemController(DB_Helper dbhelper)
        {
            _dbhelper = dbhelper;
        }
        public IActionResult Index()
        {
            var mylist =
                from a in _dbhelper.tbl_category
                join b in _dbhelper.tbl_products
                on a.C_id equals b.C_id
                join c in _dbhelper.tbl_Items on b.P_id equals c.P_id
                select new ItemViewModel
                {
                    C_id = a.C_id,
                    C_name = a.C_name,
                    P_id = b.P_id,
                    P_name = b.P_name,
                    I_id = c.I_id,
                    I_Name = c.I_Name
                };
            return View(mylist.ToList());
        }
        public IActionResult Create()
        {
            var categories = _dbhelper.tbl_category.ToList();
            var products = new List<Product>();
            ViewBag.Products = new SelectList(products, "P_id", "P_name");
            ViewBag.Categories = new SelectList(categories, "C_id", "C_name");

            return View();
        }
        //in page load//
        public JsonResult GetProductByCategoryId(int categoryId)
        {
            var del = from s in _dbhelper.tbl_products where s.C_id == categoryId select s;
            return Json(del.ToList());
            //return Json(_context.product_tb.Where(u => u.C_Id == categoryId).ToList());

        }
        //change function//
        public JsonResult GetProductByCategoryIdNew(int Itemid)
        {
            var del = from a in _dbhelper.tbl_Items join b in _dbhelper.tbl_products on a.P_id equals b.P_id where a.I_id == Itemid select b;
            return Json(del.ToList());

            
            //return Json(_context.product_tb.Where(u => u.C_Id == categoryId).ToList());

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Viewmodel m)
        {
            _dbhelper.tbl_Items.Add(m);
            await _dbhelper.SaveChangesAsync();
            return RedirectToAction("Index");
           
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _dbhelper.tbl_Items == null)
            {
                return NotFound();
            }
            var cat = await _dbhelper.tbl_Items.FindAsync(id);
            

            var categories = _dbhelper.tbl_category.ToList();
            var products = new List<Product>();
            ViewBag.Products = new SelectList(products, "P_id", "P_name");
            ViewBag.Categories = new SelectList(categories, "C_id", "C_name");
            return View(cat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Viewmodel v)
        {
            _dbhelper.Update(v);
            await _dbhelper.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
    
}
