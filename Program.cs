using System;

namespace Day19_RejexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter first name:");
            String fname = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateFirstName(fname));
            Console.WriteLine();

            Console.Write("Enter Last name:");
            String lname = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateLastName(lname));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
