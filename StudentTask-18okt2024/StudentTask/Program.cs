using System;

namespace StudentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("AB205", "afternoon");
            Student student = new Student();
            if (group != null)     // olmayan qrupa add etmemesi ucun
            {
                group.AddStudent();
            }
            group.FindStudent();
            student.Absent();
        }
    }

    public class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public int phoneNumber { get; set; }
        public string groupName { get; set; }
        public int limit { get; set; } = 24;

        public void Absent()
        {
            if (limit>1)
            {
                limit -= 1;
                Console.WriteLine($"The student does not participate in the class and the student has {limit} more chances to be absent");
            }
            else if (limit==1)
            {
                Console.WriteLine("The student was unsuccessful");
            }
        }
    }

    public class Group
    {
        public string name { get; set; } 
        public string shift { get; set; }   // Smena (növbə)
        public string[] students = ["Huseyn","Fizi"];  // Tələbə siyahısı
        public Group(string name, string shift)
        {
            this.name = name;
            this.shift = shift; //f
        }
        public void AddStudent()
        {
            Console.WriteLine("Enter the name of the person you want to add to the list:");
            Student student = new Student();
            Group group = new Group("AB205", "afternoon");
            student.name = Console.ReadLine();
           
            AddStudentToArray(ref students, student.name);
            
        }
        public void AddStudentToArray(ref string[] array, string newStudent)
        {
            string[] newArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = newStudent;
            array = newArray;
            Console.WriteLine("\nList of students in the group:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }
        public void FindStudent()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enter the name of the person you are looking for");
            string finderStudent = Console.ReadLine();
            int finderCount = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == finderStudent)
                {
                    finderCount++;
                }
                
            }
            if (finderCount != 0)
            {
                Console.WriteLine("The student you are looking for is in this list !");
            }
            else
            {
                Console.WriteLine("The student you are looking for is not in this list !");
            }
            Console.WriteLine("---------------------------");

        }
    }
}
