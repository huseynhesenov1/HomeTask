using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PurpleBuzzProject.DAL;
using PurpleBuzzProject.Models;

namespace PurpleBuzzProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurWorksController : Controller
    {
        private readonly AppDbContext _context;

        public OurWorksController(AppDbContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.OurWorks.Include(o => o.OurService);
            return View(await appDbContext.ToListAsync());
        }

       
        public IActionResult Create()
        {
            ViewBag.OurServices = new SelectList(_context.OurServices, "Id", "Title");
            return View();
        }

        
        [HttpPost]
        
        public async Task<IActionResult> Create(OurWork ourWork)
        {
            if (ModelState.IsValid)
            {
                _context.OurWorks.Add(ourWork);
               
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.OurServices = new SelectList(_context.OurServices, "Id", "Title");
            return View(ourWork);
        }

       
        

       
       

        
    }
}
