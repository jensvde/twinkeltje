using Microsoft.AspNetCore.Mvc;

namespace twinkeltje.Controllers
{
    public class WinkelController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}