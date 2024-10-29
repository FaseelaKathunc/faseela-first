using Microsoft.AspNetCore.Mvc;

namespace Multiple_layout.Controllers
{
    public class Admincontroller : Controller
    {
        public IActionResult Admin_Index()
        {
            return View();
        }

        //logout redirect to login page//
        public async Task<IActionResult> logout()
        {
            return new RedirectResult(url: "/Login/Login", permanent: true,
                        preserveMethod: true);
        }
    }
}
