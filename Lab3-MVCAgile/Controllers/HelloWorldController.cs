using Microsoft.AspNetCore.Mvc;

namespace Lab3_MVCAgile.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
