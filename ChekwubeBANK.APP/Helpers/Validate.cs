using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChekwubeBANK.APP.Helpers
{
    public class Validate
    {
        public static bool ValidateName(string name)
        {
            var regex = @"^[A-Z]";
            Regex newRegex = new Regex(regex);

            if (newRegex.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEmailValid(string email)
        {
            string emailRegex = "^[0-9A-Za-z]+[_+.-]{0,1}[0-9A-Za-z]+[@][a-zA-Z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";

            return Regex.IsMatch(email, emailRegex);
        }
        public static bool IsValidPassword(string plainText)
        {
            Regex regex = new Regex(@"^(.{0,7}|[^0-9]*|[^A-Z])$");
            Match match = regex.Match(plainText);
            return match.Success;

        }
        public static bool ValidaeAmount(decimal amount)
        {
            if(amount >= 1000)
            {
                return true ;
            }
            return false;
        }

    }
}
