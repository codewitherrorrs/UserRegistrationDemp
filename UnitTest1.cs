namespace CustomUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmailValidation()
        {
            // Arrange
            string email = "example@gmail.com";

            bool expectOutput = true;
            EmailValidator vali = new EmailValidator();

            // Act
            bool actualOutput = vali.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectOutput, actualOutput);
        }

        [TestMethod]
        public void InValidation()
        {
            // Arrange
            string email = "example@gmail";

            bool expectOutput = false;
            EmailValidator vali = new EmailValidator();

            // Act
            bool actualOutput = vali.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectOutput, actualOutput);
        }
    }
}