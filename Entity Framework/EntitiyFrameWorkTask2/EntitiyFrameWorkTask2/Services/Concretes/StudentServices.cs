using EntitiyFrameWorkTask2.Contexts;
using EntitiyFrameWorkTask2.Models;
using EntitiyFrameWorkTask2.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameWorkTask2.Services.Concretes
{
	public class StudentServices : IStudentServices
	{
		public void CreateStudent(Student student)
		{
			StudentServiceDBContext context = new StudentServiceDBContext();
			context.Students.Add(student);
			int result =context.SaveChanges();
			if (result > 0)
			{
				Console.WriteLine("Added data");
			}
			else
			{
                Console.WriteLine("Smth went wrong");
			}

        }

		public List<Student> GetAllActiveStudents()
		{
			StudentServiceDBContext dbContext = new StudentServiceDBContext();
			List<Student> DBstudents = dbContext.Students.ToList();
			return DBstudents;
		}

		public List<Student> GetAllStudents()
		{
			StudentServiceDBContext dbContext = new StudentServiceDBContext();
			List<Student> DBstudents = dbContext.Students.ToList();
			return DBstudents;
		}

		public List<Student> GetStudensByEnrollmentDate(int days)
		{
			return default;

		}

		public Student GetStudentById(int id)
		{
			StudentServiceDBContext dbContext = new StudentServiceDBContext();
			Student? student = dbContext.Students.Find(id);
            Console.WriteLine(student.FirstName+ " "+ student.LastName);
			dbContext.SaveChanges();
			return student;
		}

		public List<Student> GetStudentsByName(string name)
		{
			List<Student> students = new List<Student>();
			StudentServiceDBContext dbContext = new StudentServiceDBContext();
			
			var student = dbContext.Students.Where(s=>s.FirstName==name);
			students.AddRange(student);
            
            dbContext.SaveChanges();
			return students;

		}

		public   void HardDeleteStudent(int id)
		{
			StudentServiceDBContext dbContext = new StudentServiceDBContext();
			Student? student = dbContext.Students.Find(id);
			dbContext.Students.Remove(student);
			dbContext.SaveChanges();
		}

		public void SoftDeleteStudent(int id)
		{
			StudentServiceDBContext dbContext = new StudentServiceDBContext();
			Student? entity = dbContext.Students.Find(id);
			entity.IsDeleted = true;
			dbContext.SaveChanges();
		}

		public void UpdateStudent(int id)
		{
			StudentServiceDBContext dbContext = new StudentServiceDBContext();
			Student? entity = dbContext.Students.Find(id);
			entity.FirstName = "Huseyin";
			entity.LastName = "Nebizade";
			dbContext.SaveChanges();
		}
	}
}
