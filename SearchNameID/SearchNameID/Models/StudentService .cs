using SearchNameID.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SearchNameID.Models
{
    internal class StudentService : IStudentService
    {
        private Student[] _students;
        public StudentService( Student[] students)
        {
            _students = students;
        }
        public Student GetStudentById(int id)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Id==id)
                {
                    return _students[i];
                }
            }
            return default;
        }
        public void AddStudent(Student student)
        {
            Student[] newStudents = new Student[_students.Length+1];
            for (int i = 0; i<_students.Length; i++)
            {
                newStudents[i] = _students[i];
            }
            newStudents[_students.Length]=student;
            _students = newStudents;
        }

        public Student[] GetAllStudents()
        {
            return _students;
        }


        public Student GetStudentsByName(string name)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].FirstName == name)
                {
                    return _students[i];
                }
            }
            return default;
        }

        public void RemoveStudent(int id, bool isSoftDelete)
        {
        }

        public void UpdateStudent(int id, Student updatedStudent)
        {
            var student = GetStudentById(id);
            
                student.FirstName = updatedStudent.FirstName;
                student.LastName = updatedStudent.LastName;
                
           
        }
    }
}
