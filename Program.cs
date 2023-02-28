using System.Text.RegularExpressions;

namespace UserRegistrationDemo
{
    class Program
    {
        public static void DisValidMobileNum()
        {
            Console.WriteLine("Enter your Mobile Number  Like :- 91 9919819801  : ");
            string mobileNumber = Console.ReadLine();

            string pattern = @"^91\s\d{10}$";

            if (Regex.IsMatch(mobileNumber, pattern))
            {
                Console.WriteLine("Valid mobile number.");
            }
            else
            {
                Console.WriteLine("Invalid mobile number.");
            }




        }

        public static void Main(string[] args)
        {
            Program.DisValidMobileNum();
        }
    }
}