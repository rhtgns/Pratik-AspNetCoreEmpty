using Microsoft.AspNetCore.Mvc;

namespace Pratik_AspNetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
