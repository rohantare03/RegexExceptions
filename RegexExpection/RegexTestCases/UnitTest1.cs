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
    }
}