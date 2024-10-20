using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMod
{
    public class Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string username, string password, string name, string surname, int age, DateTime birthday)
        {
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
            Age = age;
            Birthday = birthday;
        }
    }
    
}
