using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Models
{
    public class User
    {
        private int id;
        private string name;
        private string surname;
        private static int age=5;

        public void GetFullName()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] mytypes = assembly.GetTypes();

            User user = new User();
            Type userType = typeof(User);

            FieldInfo? privateFieldName = userType.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo? privateFieldSurname = userType.GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance);

            privateFieldName?.SetValue(user, "Huseyn");
            privateFieldSurname?.SetValue(user, "Hesenov");
            Console.WriteLine($"Fullname: {privateFieldName?.GetValue(user)} {privateFieldSurname?.GetValue(user)}");
        }

        public static void ChangeAge(int newage)
        {
            
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] mytypes = assembly.GetTypes();

            User user = new User();
            Type userType = typeof(User);

            FieldInfo? privateFieldID = userType.GetField("id", BindingFlags.NonPublic | BindingFlags.Instance);

            privateFieldID?.SetValue(user, newage);
            Console.WriteLine($"New Age: {privateFieldID?.GetValue(user)}");
        }
    }
}
