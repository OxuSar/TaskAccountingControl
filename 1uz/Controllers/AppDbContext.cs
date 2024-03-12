using Microsoft.AspNetCore.Mvc;

namespace _1uz.Controllers
{
    public class AppDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
