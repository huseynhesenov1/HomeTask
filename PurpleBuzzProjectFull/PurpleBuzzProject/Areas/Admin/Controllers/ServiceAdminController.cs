using Microsoft.AspNetCore.Mvc;

using PurpleBuzzProject.DAL;
using PurpleBuzzProject.Models;

namespace PurpleBuzzProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceAdminController : Controller
    {
        readonly AppDbContext _context;

        public ServiceAdminController(AppDbContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            IEnumerable<OurWork> ourWorks =  _context.OurWorks.ToList();
            return View(ourWorks);
        }
        public IActionResult Delete(int Id)
        {
            OurWork? deleteOurWork = _context.OurWorks.Find(Id);
            if (deleteOurWork == null)
            {
                return NotFound();
            }
            else
            {
                _context.OurWorks.Remove(deleteOurWork);
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
           
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Title)
        {

            return View();
        }
    }
}
