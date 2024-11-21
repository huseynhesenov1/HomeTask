using Microsoft.AspNetCore.Mvc;
using PurpleBuzzProject.Models;

namespace PurpleBuzzProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Userr userr = new Userr()
            {
                Id = 1,
                Name = "Huseyn"
            };
            Userr userr1 = new Userr()
            {
                Id = 2,
                Name = "Hesen"
            };
            List<Userr> userrList = new List<Userr>() { userr,userr1 };
                return View(userrList);
        }
    }
}
