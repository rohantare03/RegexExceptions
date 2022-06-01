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
        public string LastName = ("^[A-Z]{1}[A-Za-z]{3,}$");
        public string Email = ("^[A-Za-z0-9]{3,}@[A-Za-z]{3,}.[a-zA-Z]{2,}$");
        public string MobileNum = ("^[0-9]{2}[ ][0-9]{10}$");
        public string First_Name(string firstName)
        {    
            try
            {
                Regex regex = new Regex(FirstName);
                if (regex.IsMatch(firstName))
                {
                    Console.WriteLine("First Name is Valid :" + firstName);
                }
                else
                {
                    Console.WriteLine("First Name is Invalid");
                }
                return firstName;
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.FIRSTNAME_INVALID, "First name should not be invalid");
            }
        }
        public string Last_Name(string lastName)
        {
            try
            {
                Regex regex = new Regex(LastName);
                if (regex.IsMatch(lastName))
                {
                    Console.WriteLine("Last Name is Valid :" + lastName);
                }
                else
                {
                    Console.WriteLine("Last Name is Invalid");
                }
                return lastName;
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.LASTNAME_INVALID, "Last name should not be invalid");
            }
        }
        public string EmailId(string Email_Id)
        {
            try
            {
                Regex regex = new Regex(Email);
                if (regex.IsMatch(Email_Id))
                {
                    Console.WriteLine("Email is Valid :" + Email_Id);
                }
                else
                {
                    Console.WriteLine("Email is invalid");
                }
                return Email_Id;
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.EMAIL_INVALID, "Email should not be invalid");
            }
        }
        public string Mobile(string Mobile_Num)
        {
            try
            {
                Regex regex = new Regex(MobileNum);
                if (regex.IsMatch(Mobile_Num))
                {
                    Console.WriteLine("Mobile Number is Valid :" + Mobile_Num);
                }
                else
                {
                    Console.WriteLine("Mobile Number is invalid");
                }
                return Mobile_Num;
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.MOBILE_INVALID, "Mobile Number should not be invalid");
            }
        }
    }
}
