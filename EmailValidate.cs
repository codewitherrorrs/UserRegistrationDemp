using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationDemo
{
    public class EmailValidate
    {
       public  string message = "Exception Not Occur";
        public void validate(string firstName,string lastName,String email,string mobile,string password)
        {
            if(firstName == null && lastName == null && email == null && mobile == null && password == null) 
            {
                throw new Exception("All details is not filled Exception");
            }
            else
            {
                Console.WriteLine("Message : "+message);
            }
        }
    }
}
