using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExpection
{
    public class Validation
    {
        public string FirstName = ("^[A-Z]{1}[A-Za-z]{2,}$");
        public string LastName = ("^[A-Z]{1}[A-Za-z]{2,}$");
        public string First_Name(string firstName)
        {
            try
            {
                Regex regex = new Regex(FirstName);
                if (regex.IsMatch(firstName))
                {
                    Console.WriteLine("Firstname is valid :" + firstName);
                    return firstName;
                }
                else
                {
                    throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.FIRSTNAME_INVALID, "First Name is invalid");
                }
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.FIRSTNAME_INVALID, "First Name is invalid");
            }
        }
        public string Last_Name(string lastName)
        {
            try
            {
                Regex regex = new Regex(LastName);
                if (regex.IsMatch(lastName))
                {
                    Console.WriteLine("Lastname is valid :" + lastName);
                    return lastName;
                }
                else
                {
                    throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.LASTNAME_INVALID, "Last Name is invalid");
                }
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.LASTNAME_INVALID, "Last Name is invalid");
            }
        }
    }
}
