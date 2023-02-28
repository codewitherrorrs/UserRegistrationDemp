using System.Text.RegularExpressions;

namespace UserRegistrationDemo
{
    class Program
    {
        public static void DisplayFName()
        {
            Console.WriteLine("Enter your FirstName");
            string firstName = Console.ReadLine();

            if (Regex.IsMatch(firstName, "^[A-Z][a-z]{2,}$"))
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }



        }

        public static void Main(string[] args)
        {
            Program.DisplayFName();
        }
    }
}