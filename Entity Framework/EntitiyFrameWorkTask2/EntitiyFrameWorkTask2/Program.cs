using EntitiyFrameWorkTask2.Contexts;
using EntitiyFrameWorkTask2.Models;
using EntitiyFrameWorkTask2.Services.Abstractions;
using EntitiyFrameWorkTask2.Services.Concretes;
Student student1 = new Student()
{
	FirstName = "Hesen",
	LastName = "Hesenov",
	Username = "Hesenov",
	Password = "Hesenli1234",
	EnrollmentDate = new DateTime(2005-10-25),
	IsDeleted = true,
}; 
IStudentServices studentServices= new StudentServices();
//studentServices.CreateStudent(student1);
//studentServices.HardDeleteStudent(1);
//studentServices.SoftDeleteStudent(2);
//studentServices.UpdateStudent(3);
#region GetAllStudents
//foreach (var item in studentServices.GetAllStudents())
//{
//    Console.WriteLine(item.FirstName+ " " +item.LastName);
//}
#endregion

#region GetAllActiveStudents
//foreach (var item in studentServices.GetAllActiveStudents())
//{
//	if (item.IsDeleted == true)
//	{
//		Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.IsDeleted);
//	}
//}
#endregion

#region GetStudentsByName
//foreach (var item in studentServices.GetStudentsByName("Eli").ToList())
//{
//	Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
//}
#endregion


