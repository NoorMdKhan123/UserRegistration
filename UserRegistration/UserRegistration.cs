using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserRegistration

    {
        public string regExPattern = "^[A-Z]{1}[a-z]{2,5}$";
        public bool ValidateName(string firstname)
        {
            return Regex.IsMatch(firstname, regExPattern);
        }
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, regExPattern);
        }
    }
}