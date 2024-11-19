using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameWorkTask2.Models
{
	public class Student:BaseEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public DateTime? DOB { get; set; }
		public DateTime? EnrollmentDate { get; set; }
	}
}
