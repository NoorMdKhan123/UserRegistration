using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
        string firstName;


        Pattern userRegistration = new Pattern();
        Console.WriteLine("Enter first name : ");
            firstName = Console.ReadLine();

            result = Pattern.ValidateName(firstName);
            Console.WriteLine(result);
        }
    }
}