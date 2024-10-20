using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomValidator
{
    public class Validator
    {
        public bool IsValidUsername(string username)
        {
            return username.Length >= 2;
        }

        public bool IsValidName(string name)
        {
            return name.Length >= 2;
        }

        public bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        public bool IsValidAge(int age)
        {
            return age > 0;
        }

        public bool IsValidBirthday(DateTime birthday)
        {
            return birthday.Year >= 1970;
        }
    }
}
