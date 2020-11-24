using System;

namespace srp
{
    class PersonDataCapture
    {
        public static Person CapturePerson()
        {
            Person output = new Person();

            Console.WriteLine("What's your first name?");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
