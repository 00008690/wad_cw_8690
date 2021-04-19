using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD._8690.APP
{
    public class Email
    {
        public string MailAddress { get; set; }
        public Email()
        {
            
        }
        //comment
        public void IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                Console.WriteLine("Email is valid /*this is from Email class*/");
            }
            catch
            {
                Console.WriteLine("Email is not valid /*this is from Email class*/");
            }
        }
    }
}
