using System.Text.RegularExpressions;

namespace UserRegistrationDemo
{
    class Program
    {
        public static void DisValidPassValid()
        {
            Console.WriteLine("Enter a password Like :- Abc1234$ , P@ssw0rd1 , 12Monkeys : ");
            string password = Console.ReadLine();

            if (!Regex.IsMatch(password, @"^(?=.*\d)[^\s]{8,}$"))
            {
                Console.WriteLine("Invalid password. The password must contain at least 8 characters, including at least one numeric digit, and must not contain any spaces.");
            }
            else
            {
                Console.WriteLine("Password is valid.");
            }
        }

        public static void Main(string[] args)
        {
            Program.DisValidPassValid();
        }
    }
}