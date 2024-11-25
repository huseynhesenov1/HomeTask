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
            IEnumerable<OurService> ourServices =  _context.OurServices.ToList();
            return View(ourServices);
        }
        public IActionResult Delete(int Id)
        {
            OurService? deleteOurWork = _context.OurServices.Find(Id);
            if (deleteOurWork == null)
            {
                return NotFound();
            }
            else
            
            {
                _context.OurServices.Remove(deleteOurWork);
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
           
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(OurService ourService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("smth went wrong");
            }
            else
            {
                _context.OurServices.Add(ourService);
                _context.SaveChanges();
            }

            
            return RedirectToAction(nameof(Index));
        }
    }
}
