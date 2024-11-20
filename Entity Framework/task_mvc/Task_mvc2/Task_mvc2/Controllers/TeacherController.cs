using Microsoft.AspNetCore.Mvc;
using Task_mvc2.Models;

namespace Task_mvc2.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            Teacher teacher1 = new Teacher()
            {
                Id = 1,
                Name = "Nermin",
                Surname = "Khan",
                Description = "Muhazire"
            };
            Teacher teacher2 = new Teacher()
            {
                Id = 2,
                Name = "Vilayet",
                Surname = "Aliyev",
                Description = "Lab"
            };
            List<Teacher> teachers = new List<Teacher>() { teacher1, teacher2 };
            return View(teachers);
        }
    }
}
