using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Pattern
    {
        public static string regExPattern = "^[A-Z]{1}[a-z]{2,5}$";
        public static bool ValidateName(string firstname)
        {
            return Regex.IsMatch(firstname, regExPattern);
        }
    }
}