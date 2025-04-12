using Microsoft.AspNetCore.Mvc;

namespace Sample.sample
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
