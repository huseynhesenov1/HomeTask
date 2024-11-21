using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
