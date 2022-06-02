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
        }
    }
}
