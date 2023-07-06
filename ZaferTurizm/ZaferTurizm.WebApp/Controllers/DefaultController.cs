using Microsoft.AspNetCore.Mvc;

namespace ZaferTurizm.WebApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
