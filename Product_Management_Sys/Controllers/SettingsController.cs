using Microsoft.AspNetCore.Mvc;

namespace Product_Management_Sys.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
