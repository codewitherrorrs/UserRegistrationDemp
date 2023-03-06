using UserRegistrationDemo;
namespace TestValidate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmailValidate1()
        {

        //Arrange
        string firstName = "Sagar";
        string lastName = "Shahu";
        string email = "shahu@gmail.com";
        string mobile = "6254892";
        string password = "pass123";
        string expectedOutput = "HAPPY";
        EmailValidate e1 = new EmailValidate();

        //Act
        string actualOutput = e1.validate(firstName,lastName,email,mobile,password);
        
        //Assert
        Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}