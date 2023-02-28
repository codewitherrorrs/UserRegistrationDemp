using System.Text.RegularExpressions;

namespace UserRegistrationDemo
{
    class Program
    {
        public static void DisplayLastName()
        {
            Console.WriteLine("Enter your FirstName");
            string lastName = Console.ReadLine();

            if (Regex.IsMatch(lastName, "^[A-Z][a-z]{2,}$"))
            {
                Console.WriteLine("Valid Last name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }



        }

        public static void Main(string[] args)
        {
            Program.DisplayLastName();
        }
    }
}