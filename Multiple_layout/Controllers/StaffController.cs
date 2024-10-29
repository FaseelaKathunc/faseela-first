using Microsoft.AspNetCore.Mvc;

namespace Multiple_layout.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Staff_index()
        {
            return View();
        }
        public async Task<IActionResult> logout()
        {
            return new RedirectResult(url: "/Login/Login", permanent: true,
                        preserveMethod: true);
        }
    }
}
