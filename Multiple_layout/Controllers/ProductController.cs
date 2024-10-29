using Microsoft.AspNetCore.Mvc;

namespace Multiple_layout.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
