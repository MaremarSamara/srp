using System;
using System.Collections.Generic;
using System.Text;

namespace srp
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine("You didn't enter a valid first name!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Console.WriteLine("You didn't enter a valid last name!");
                return false;
            }

            return true;
        }
    }
}
