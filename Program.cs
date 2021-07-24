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
        }
    }
}
