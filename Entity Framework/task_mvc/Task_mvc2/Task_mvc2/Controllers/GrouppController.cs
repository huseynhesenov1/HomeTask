using Microsoft.AspNetCore.Mvc;
using Task_mvc2.Models;

namespace Task_mvc2.Controllers
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
