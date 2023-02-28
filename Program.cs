using System.Text.RegularExpressions;

namespace UserRegistrationDemo
{
    class Program
    {
        public static void DisplayValidEmail()
        {
            Console.WriteLine("Enter your email Like : -abc.xyz@bl.co.in : ");
            string email = Console.ReadLine();
            string pattern = @"^[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*\.(co\.in|in)$";

            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }


        }

        public static void Main(string[] args)
        {
            Program.DisplayValidEmail();
        }
    }
}