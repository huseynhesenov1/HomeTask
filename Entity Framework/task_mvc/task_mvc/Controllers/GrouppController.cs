using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using task_mvc.Models;

namespace task_mvc.Controllers
{
	public class GrouppController : Controller
	{
		public IActionResult Index()
		{
			Groupp groupp = new Groupp()
			{
				Id = 1,
				Name = "Ab205",
				MemberCount = 15,
			};
			Groupp groupp1 = new Groupp()
			{
				Id = 1,
				Name = "682a3",
				MemberCount = 26,
			};
			List<Groupp> groupps = new List<Groupp>() { groupp, groupp1 };
			return View(groupps);
		}
	}
}
