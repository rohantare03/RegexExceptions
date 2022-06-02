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
        public string Email = ("^[A-Za-z0-9]{3,}@[A-Za-z]{3,}.[a-zA-Z]{2,}$");
        public string MobileNum = ("^[0-9]{2}[ ][0-9]{10}$");
        public string PassWord = ("^[A-Za-z0-9@#$%^&*+]{8,}$");
        public string PassWord2 = ("^[A-Z]{1,}[A-Za-z0-9@#$%^&*+]{7,}$");
        public string PassWord3 = ("^[A-Z]{1,}[A-Za-z0-9@#$%^&*+]{6,}[0-9]{1,}$");
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
        public string EmailId(string Email_Id)
        {
            try
            {
                Regex regex = new Regex(Email);
                if (regex.IsMatch(Email_Id))
                {
                    Console.WriteLine("EmailId is valid :" + Email_Id);
                    return Email_Id;
                }
                else
                {
                    throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.EMAILID_INVALID, "Email is invalid");
                }
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.EMAILID_INVALID, "Email is invalid");
            }
        }
        public string Mobile(string Mobile_Num)
        {
            try
            {
                Regex regex = new Regex(MobileNum);
                if (regex.IsMatch(Mobile_Num))
                {
                    Console.WriteLine("Mobile Number is valid :" + Mobile_Num);
                    return Mobile_Num;
                }
                else
                {
                    throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.MOBILE_INVALID, "Mobile Number is invalid");
                }
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.MOBILE_INVALID, "Mobile Number is invalid");
            }
        }
        public string Validate_PassWord(string passWord)
        {
            try
            {
                Regex regex = new Regex(PassWord);
                if (regex.IsMatch(passWord))
                {
                    Console.WriteLine("Password is valid :" + passWord);
                    return passWord;
                }
                else
                {
                    throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
                }
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
            }
        }
        public string Validate_PassWord2(string passWord2)
        {
            try
            {
                Regex regex = new Regex(PassWord2);
                if (regex.IsMatch(passWord2))
                {
                    Console.WriteLine("Password is valid :" + passWord2);
                    return passWord2;
                }
                else
                {
                    throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
                }
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
            }
        }
        public string Validate_PassWord3(string passWord3)
        {
            try
            {
                Regex regex = new Regex(PassWord3);
                if (regex.IsMatch(passWord3))
                {
                    Console.WriteLine("Password is valid :" + passWord3);
                    return passWord3;
                }
                else
                {
                    throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
                }
            }
            catch
            {
                throw new RegexCustomExpection(RegexCustomExpection.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
            }
        }
    }
}
