using Microsoft.AspNetCore.Mvc;

namespace biblioteca.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}