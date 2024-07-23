using Microsoft.AspNetCore.Mvc;

namespace Product_Management_Sys.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
