using Microsoft.AspNetCore.Mvc;
using Multiple_layout.Models;
using Multiple_layout.Data;
using Microsoft.EntityFrameworkCore;

namespace Multiple_layout.Controllers
{
    public class LoginController : Controller
    {
        public readonly DB_Helper _dbhelper;
        public LoginController (DB_Helper dbhelper)
        {
            _dbhelper=dbhelper;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registration() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(Register rg)
        {
           _dbhelper.tbl_Register.Add(rg);
            await _dbhelper.SaveChangesAsync();
            return View();  


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> log(Register rg)
        {
            var type = "";
            var data=from l in _dbhelper.tbl_Register
                     where l.Email==rg.Email && l.Password==rg.Password
                     select l;
            foreach(var dd in data)
            {
                type=dd.type;
                if (type == "Admin")
                {
                    return new RedirectResult(url: "/Admin/Admin_Index", permanent: true,
                        preserveMethod: true);
                }
                else if (type == "Staff")
                {
                    return new RedirectResult(url: "/Staff/Staff_index", permanent: true,
                        preserveMethod: true);
                }
            }
            return Ok();

        }
       
            
    }
}
