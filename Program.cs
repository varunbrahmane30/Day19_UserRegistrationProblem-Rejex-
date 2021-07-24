using System;

namespace Day19_RejexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Enter the Details ");
            Console.WriteLine();

            Console.Write("Enter first name : ");
            String fname = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateFirstName(fname));
            Console.WriteLine();

            Console.Write("Enter Last name : ");
            String lname = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateLastName(lname));
            Console.WriteLine();

            Console.Write("Enter Eamil : ");
            String email = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateEmail(email));
            Console.WriteLine();

            Console.Write("Enter Mobile Number : ");
            String mobileNo = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateMobileNo(mobileNo));
            Console.WriteLine();

            Console.Write("Enter Password : ");
            String password = Console.ReadLine();
            Console.WriteLine(UserRegistration.validatePassword(password));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
