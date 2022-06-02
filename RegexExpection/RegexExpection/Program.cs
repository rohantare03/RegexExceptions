namespace RegexExpection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Validation");
            Validation validation = new Validation();
            //uc1 : first  name
            Console.WriteLine("Enter the First Name : ");
            string first_Name = Console.ReadLine();
            validation.First_Name(first_Name);

            //uc2 : last name
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Last Name");
            string last_Name = Console.ReadLine();
            validation.Last_Name(last_Name);

            //uc3 : Email
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Email Id");
            string email_Id = Console.ReadLine();
            validation.EmailId(email_Id);

            //uc4 : Mobile Number
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Mobile Number");
            string mobileNum = Console.ReadLine();
            validation.Mobile(mobileNum);

            //uc5 : Password
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password");
            string Password = Console.ReadLine();
            validation.Validate_PassWord(Password);

            //uc6 : Password with minimum one upper case
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with minimum one upper case: ");
            string Password2 = Console.ReadLine();
            validation.Validate_PassWord(Password2);

            //uc7 : Password
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with minimum one numeric value : ");
            string Password3 = Console.ReadLine();
            validation.Validate_PassWord(Password3);
        }
    }
}
