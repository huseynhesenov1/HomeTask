using SearchNameID.Interface;
using SearchNameID.Models;

namespace SearchNameID;

internal class Program
{
    static void Main(string[] args)
    {
        Student student = new Student()
        {
            Id = 1,
            FirstName = "Huseyn",
            LastName="Hesenov"
        };
        Student student2 = new Student()
        {
            Id = 2,
            FirstName = "Hesen",
            LastName = "Hesenov"

        };
        Student student3 = new Student()
        {
            Id = 3,
            FirstName = "Eli",
            LastName = "Hesenov"

        };
        Student student4 = new Student()
        {
            Id = 4,
            FirstName = "Abidin",
            LastName = "Hesenov"

        };
        Student[] students = {student, student2, student3, student4};
        IStudentService studentService = new StudentService(students);


        #region UpdateStudent
        //Console.WriteLine("Update etmek istediyiniz telebenin ID-sini yaz");
        //int updateId = int.Parse(Console.ReadLine());
        //studentService.UpdateStudent(updateId, new Student { FirstName = "Zefer", LastName = "Hesenov" });
        //Student[] studentAll = studentService.GetAllStudents();
        //foreach (var st in studentAll)
        //{
        //    Console.WriteLine($"Adi:{st.FirstName} \nSoyadi:{st.LastName}");
        //}
        #endregion


        #region GetStudentById
        Console.WriteLine("Axtarmaq istediyiniz telebenin ID-sini daxil edin");
        int searchId = int.Parse(Console.ReadLine());
        Student studentObj = studentService.GetStudentById(searchId);
        Console.WriteLine($"Id:{studentObj.Id} \nAdi:{studentObj.FirstName} \nSoyadi:{studentObj.LastName}");
        #endregion






        #region GetStudentsByName
        //Console.WriteLine("Axtaracaginiz telebenin adini yaz");
        //string serachName = Console.ReadLine();
        //Student studentObj = studentService.GetStudentsByName(serachName);
        //Console.WriteLine($"Id:{studentObj.Id} \nAdi:{studentObj.FirstName} \nSoyadi:{studentObj.LastName}");
        #endregion



        #region AddStudent, GetAllStudents

        //Student newStudent = new Student
        //{
        //    Id = default,
        //    FirstName = null,
        //    LastName = null

        //};
        //Console.Write("Elave etmek istediyin telebenin ID-sini yaz: ");
        //newStudent.Id = int.Parse(Console.ReadLine());
        //Console.Write("Elave etmek istediyin telebenin adini yaz: ");
        //newStudent.FirstName = Console.ReadLine();
        //Console.Write("Elave etmek istediyin telebenin soyadini yaz: ");
        //newStudent.LastName = Console.ReadLine();
        //Console.WriteLine("Yeni telebe elave edildi");
        //studentService.AddStudent(newStudent);
        //Student[] updatedStudents = studentService.GetAllStudents();
        //foreach (var st in updatedStudents)
        //{
        //    Console.WriteLine($"Adi:{st.FirstName} \nSoyadi:{st.LastName}");
        //}
        #endregion




        #region Remove

        //Console.WriteLine("Silmek istedyiniz elementin ID-sini yazin");
        //int RemoveID = Convert.ToInt32(Console.ReadLine());      
        //studentService.RemoveStudent(RemoveID, false);
        //Student[] studentAll = studentService.GetAllStudents();
        //foreach (var st in studentAll)
        //{
        //    Console.WriteLine($"Adi:{st.FirstName} \nSoyadi:{st.LastName}");
        //}

        #endregion
    }
}