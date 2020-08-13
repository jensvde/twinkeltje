using Microsoft.AspNetCore.Mvc;

namespace twinkeltje.Controllers
{
    public class AdminController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}