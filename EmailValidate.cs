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
       

        public string validate(string firstName,string lastName,String email,string mobile,string password)
        {
            if(firstName== "" && lastName == "" && email == "" && mobile == "" && password == "") 
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
