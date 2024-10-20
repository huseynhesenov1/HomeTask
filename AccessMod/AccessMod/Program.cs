using System.ComponentModel.DataAnnotations;
using CustomValidator;

namespace AccessMod
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomValidator.Validator validator = new CustomValidator.Validator();

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your birth date (YYYY.MM.DD)");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            var person = new Person(username, password, name, surname, age, birthday);

            if (!validator.IsValidUsername(person.Username))
            {
                Console.WriteLine("Username must be at least 2 characters long.");
            }
            else if (!validator.IsValidName(person.Name) || !validator.IsValidName(person.Surname))
            {
                Console.WriteLine("Name and surname must be at least 2 characters long.");
            }
            else if (!validator.IsValidPassword(person.Password))
            {
                Console.WriteLine("Password must be at least 8 characters long and contain a number, symbol, uppercase and lowercase letter.");
            }
            else if (!validator.IsValidAge(person.Age))
            {
                Console.WriteLine("Age must be greater than 0.");
            }
            else if (!validator.IsValidBirthday(person.Birthday))
            {
                Console.WriteLine("Birth year must be greater than 1970.");
            }
            else
            {
                Console.WriteLine("Person added successfully.");
            }
        }
    }
}
