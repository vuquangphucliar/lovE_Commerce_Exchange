using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BUS
{
    public class BUS_signup
    {
        
        public static bool RePasswordChecking(string first_pass, string second_pass)
        {
            if (first_pass == second_pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PasswordChecking(string password)
        {
            if (password.Length > 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool UserNameFormatChecking(string username)
        {
            if(string.IsNullOrEmpty(username))
            {
                return true;
            }
            if(username.Length < 6)
            {
                return true;
            }
            return false;
        }
        public static bool PasswordFormatChecking(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return true;
            }
            if (password.Length < 6)
            {
                return true;
            }
            return false;

        }

        public static bool EmailFormatChecking(string email)
        {
            if (email == null || email == "")
            {
                return true;
            }
            if (email.Length <= 10)
            {
                return true;
            }
            if (!email.Contains("@gmail.com"))
            {
                return true;
            }
            string[] chars = "~ ` ! @ # $ % ^ & * ( ) _ + - = { } [ ] | ; ' : ? / > < > , .".Split(' ');
            foreach (string ch in chars)
            {
                string temp = email.Substring(0, email.Length - 10);
                if (temp.Contains(ch))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
