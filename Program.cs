using System;

namespace srp
{
    class Program
    {
        static void Main(string[] args)
        {
            StandradMessages.WelcomeMessage();

            Person user = PersonDataCapture.CapturePerson();

            bool isValid = PersonValidator.Validate(user);

            if (isValid == false)
            {
                StandradMessages.TerminateApplicationMessage();
            }

            Generator.GenerateUserName(user);

            StandradMessages.TerminateApplicationMessage();
        }
    }
}
