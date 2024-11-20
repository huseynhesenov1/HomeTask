using Microsoft.AspNetCore.Mvc;
using Task_mvc2.Models;

namespace Task_mvc2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Huseyn",
                Surname = "Hesenov",
                Age = 20
            };
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Hesen",
                Surname = "Hesenov",
                Age = 19
            };
            List<Student> students = new List<Student>()
            {
                student, student1
            };

            return View(students);
        }
    }
}
