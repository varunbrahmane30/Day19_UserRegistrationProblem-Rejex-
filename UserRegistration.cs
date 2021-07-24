using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_RejexUserRegistration
{
    class UserRegistration
    {
       
        public static string Regex_Name = "^[A-Z]{1}[A-Za-z]{1}[a-zA-Z]*$";
        public static string Regex_lName = "^[A-Z]{1}[A-Za-z]{1}[a-zA-Z]*$";

        public static String validateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, Regex_Name) == true)
                return "First name is Valid";
            else
                return "First name is InValid";
        }

        public static String validateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, Regex_lName) == true)
                return "last name is Valid";
            else
                return "last name is InValid";
        }
    }

}

