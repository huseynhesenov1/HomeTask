using ReflectionTask.Models;
using System.Reflection;

namespace ReflectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           User user = new User();
           user.GetFullName();
           User.ChangeAge(25);
        }
    }
}
