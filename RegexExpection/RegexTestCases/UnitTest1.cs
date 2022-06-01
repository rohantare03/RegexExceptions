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
            string expected = "First name should not be invalid";
            try
            {
                //Act
                validation = new Validation();
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
            string expected = "Last name should not be invalid";
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
            string expected = "Email should not be invalid";
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
        //uc4 : Comparing the Mobile Number of user
        //</summary>
        [Test]
        public void Comparing_the_Mobile_Number_of_User()
        {
            //Arrange
            string Mobile_Num = "915849921";
            string expected = "Mobile Number should not be invalid";
            try
            {
                //Act
                validation = new Validation();
                validation.Mobile(Mobile_Num);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc5 : Comparing the Password of user
        //</summary>
        [Test]
        public void Comparing_the_Password_of_User()
        {
            //Arrange
            string passWord = "rohat";
            string expected = "Password should not be invalid";
            try
            {
                //Act
                validation = new Validation();
                validation.Validate_PassWord(passWord);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc6: Comparing the Password with minimum one upper case of user
        //</summary>
        [Test]
        public void Comparing_the_Password_With_Minimum_one_Upper_Case_of_User() 
        {
            //Arrange
            string passWord2 = "rohatare";
            string expected = "Password2 should not be invalid";
            try
            {
                //Act
                validation = new Validation();
                validation.Validate_PassWord2(passWord2);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
        //<summary>
        //uc6: Comparing the Password with minimum one numeric value of user
        //</summary>
        [Test]
        public void Comparing_the_Password_With_minimum_one_Numeric_Value_of_User() 
        {
            //Arrange
            string passWord3 = "RohaTare";
            string expected = "Password3 should not be invalid";
            try
            {
                //Act
                validation = new Validation();
                validation.Validate_PassWord3(passWord3);
            }
            catch (RegexCustomExpection expection)
            {
                //Assert
                Assert.AreEqual(expected, expection.Message);
            }
        }
    }
}