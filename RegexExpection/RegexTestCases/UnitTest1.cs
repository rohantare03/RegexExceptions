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
    }
}