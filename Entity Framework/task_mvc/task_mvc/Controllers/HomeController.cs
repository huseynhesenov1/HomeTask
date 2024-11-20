using Microsoft.AspNetCore.Mvc;
using task_mvc.Models;

namespace task_mvc.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			Student student = new Student()
			{
				Id = 1,
				Name="Huseyn",
				Surname = "Hesenov",
				Age=20
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
			//JsonResult jsonResult = new JsonResult(student);
			return View(students);
		}

	}
}
