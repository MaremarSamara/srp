using System;

namespace srp
{
    class Program
    {
        static void Main(string[] args)
        {
            // if we want to change the welcome message, we need to make chgange in this class
            Console.WriteLine("Wlcome to the application");

            // Ask for user information
            Person user = new Person();

            // if we want to change how to capture the first and last name, we need to make chgange in this class
            Console.WriteLine("What's your first name?");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            user.LastName = Console.ReadLine();

            // if we want to change how to validate the first and last name, we need to make chgange in this class
            // checks to be sure user frist name and user last name are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You didn't enter a valid first name!");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You didn't enter a valid last name!");
                Console.ReadLine();
                return;
            }

            // if we want to change how to genrate the username, we need to make chgange in this class
            // generate username
            Console.WriteLine("Your username is: " + user.FirstName + user.FirstName);
            Console.ReadLine();

        }
    }
}
