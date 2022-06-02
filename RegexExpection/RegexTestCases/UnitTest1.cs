using NUnit.Framework;
using RegexExpection;

namespace RegexTestCases
{
    public class Tests
    {
        Validation validation;
        [SetUp]
        public void Setup()
        {
            validation = new Validation();
        }
        //<summary>
        //uc1 : Comparing the first name of user
        //</summary>
        [Test]
        public void Comparing_the_First_Name_of_User()
        {
            //Arrange
            string firstName = "rohan";
            string expected = "First Name is invalid";
            try
            {
                //Act
                validation.First_Name(firstName);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc2 : Comparing the last name of user
        //</summary>
        [Test]
        public void Comparing_the_Last_Name_of_User()
        {
            //Arrange
            string lastName = "tae";
            string expected = "Last Name is invalid";
            try
            {
                //Act
                validation = new Validation();
                validation.Last_Name(lastName);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc3 : Comparing the EmailId of user
        //</summary>
        [Test]
        public void Comparing_the_EmailId_of_User()
        {
            //Arrange
            string Email_Id = "rohantare";
            string expected = "Email is invalid";
            try
            {
                //Act
                validation = new Validation();
                validation.EmailId(Email_Id);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc4 : Comparing the mobile number of user
        //</summary>
        [Test]
        public void Comparing_the_Mobile_Number_of_User()
        {
            //Arrange
            string Mobile_num = "9158499217";
            string expected = "Mobile Number is invalid";
            try
            {
                //Act                
                validation.Mobile(Mobile_num);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc5 : Comparing the password of user
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User()
        {
            //Arrange
            string password = " ";
            string expected = "Password is invalid";
            try
            {
                //Act                
                validation.Validate_PassWord(password);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc6 : Comparing the password of user with minimum one upper case
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_Minimum_one_Upper_Case()
        {
            //Arrange
            string password2 = "rohant";
            string expected = "Password is invalid";
            try
            {
                //Act               
                validation.Validate_PassWord2(password2);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc7 : Comparing the password of user with minimum one numeric value
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_Minimum_one_Numeric_Value()
        {
            string password3 = "RohanTare";
            string expected = "Password is invalid";
            try
            {
                //Act                
                validation.Validate_PassWord3(password3);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc8 : Comparing the password of user with exactly one special character
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User_exactly_one_Special_Character()
        {
            string password4 = "RohanTare99";
            string expected = "Password is invalid";
            try
            {
                //Act
                validation.Validate_PassWord4(password4);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc9 : Comparing the Emails of all the given sample Emails
        //</summary>
        [Test]
        public void Comparing_the_Emails_of_all_the_given_Sample_Emails()
        {
            string allemail = " ";
            string expected = "Email is invalid";
            try
            {
                //Act
                validation.Validate_AllEmails(allemail);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
    }
}