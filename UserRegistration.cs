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
        public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Regex_MobileNo = "(0|91)?[ ][6-9][0-9]{9}";

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

        public static String validateEmail(string email)
        {
            if (Regex.IsMatch(email, Regex_Email) == true)
                return "Email is Valid";
            else
                return "Email is InValid";
        }

        public static String validateMobileNo(string mobileNo)
        {
            if (Regex.IsMatch(mobileNo, Regex_MobileNo) == true)
                return "Mobile Number is Valid";
            else
                return "Mobile Number is InValid";
        }
    }

}

