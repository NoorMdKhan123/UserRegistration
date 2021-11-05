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
        string regExEmail = "^(?=.{1,32}@)[A-Za-z0-9_-]+(\\.[A-Za-z0-9_-]+)*@[^-]" +
            "[A-Za-z0-9-]+(\\.[A-Za-z0-9-]+)*(\\.[A-Za-z]{2,})$";

        public bool UserEmailValidation(string email)
        {
            return Regex.IsMatch(email, regExEmail);
        }
        public string regExPattern2 = "^91?[0-9]{10}$";

        public bool PhoneNumberCheck(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, regExPattern2);

        }
        public string regEx3 = "(?=.*[0-9])(?=.*[A-Z])(?=.*?[#?!@$%^&*-]).{8,20}$";

        public string Password(string password)
        {
            bool result = Regex.IsMatch(password, regEx3);
            if (result)
            {
                return "password is correct";
            }
            else
            {
                return "passowrd incorrect";
            }
        }
    }
}