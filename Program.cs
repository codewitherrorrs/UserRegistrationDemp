using System.Text.RegularExpressions;

namespace UserRegistrationDemo
{
    class Program
    {
        public static void DisValidMobileNum()
        {
            Console.WriteLine("You Enter  Password first Later Capital  Password like:- .Qwerty1  , !Q1w2e3r4  : ");
            string password = Console.ReadLine();



            string pattern = ("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

            if (Regex.IsMatch(password, pattern))
            {

                Console.WriteLine("Password is valid.");
            }
            else
            {

                Console.WriteLine("Password must be at least 8 characters.");
            }

        }

        public static void Main(string[] args)
        {
            Program.DisValidMobileNum();
        }
    }
}