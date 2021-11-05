using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            string firstName;
            string lastName;
            string useremail;


            UserRegistration userRegistration = new UserRegistration();

            Console.WriteLine("Enter first name : ");
            firstName = Console.ReadLine();
            result = userRegistration.ValidateName(firstName);
            Console.WriteLine(result);
            Console.WriteLine("-----------");

            Console.WriteLine("Enter last name : ");
            lastName = Console.ReadLine();
            result = userRegistration.ValidateName(lastName);
            Console.WriteLine(result);
            Console.WriteLine("-----------");

            Console.WriteLine("Enter email");
            useremail = Console.ReadLine();
            result = userRegistration.UserEmailValidation(useremail);
            Console.WriteLine(result);
            Console.WriteLine("-----------");
        }
    }
}