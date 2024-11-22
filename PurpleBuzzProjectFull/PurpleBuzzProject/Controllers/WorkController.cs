using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzProject.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
