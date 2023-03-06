using System.Text.RegularExpressions;

namespace UserRegistrationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define lambda functions for validation
            Func<string, bool> validateFirstName = name => Regex.IsMatch(name, @"^[A-Za-z]{2,20}$");
            Func<string, bool> validateLastName = name => Regex.IsMatch(name, @"^[A-Za-z]{2,20}$");
            Func<string, bool> validateEmail = email => Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            Func<string, bool> validateMobile = mobile => Regex.IsMatch(mobile, @"^[0-9]{10}$");
            Func<string, bool> validatePassword = password => Regex.IsMatch(password, @"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[^\da-zA-Z]).{8,20}$");

            // Test the lambda functions
            Console.WriteLine(validateFirstName("John")); // true
            Console.WriteLine(validateFirstName("J")); // false
            Console.WriteLine(validateLastName("Doe")); // true
            Console.WriteLine(validateLastName("D")); // false
            Console.WriteLine(validateEmail("john.doe@example.com")); // true
            Console.WriteLine(validateEmail("john.doe@.com")); // false
            Console.WriteLine(validateMobile("1234567890")); // true
            Console.WriteLine(validateMobile("123456")); // false
            Console.WriteLine(validatePassword("Passw0rd!")); // true
            Console.WriteLine(validatePassword("password")); // false
        }
        
    }
}