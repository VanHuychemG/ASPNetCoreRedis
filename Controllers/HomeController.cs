using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreRedis.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
