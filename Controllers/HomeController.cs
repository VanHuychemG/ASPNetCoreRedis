using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ASPNetCoreRedis.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("MyPageTitle", "Redis Rules!");

            ViewBag.Message = HttpContext.Session.GetString("MyPageTitle");

            return View();
        }
    }
}
