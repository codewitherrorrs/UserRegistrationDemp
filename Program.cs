using System.Text.RegularExpressions;

namespace UserRegistrationDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an email address : ");
            string email = Console.ReadLine();


            if (ValidateEmail(email))
            {
                Console.WriteLine("The email address is valid.");
            }
            else
            {
                Console.WriteLine("The email address is invalid.");
            }
        }

        static bool ValidateEmail(string email)
        {

            string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";


            Match match = Regex.Match(email, emailRegex);


            return match.Success;
        }
    }
}