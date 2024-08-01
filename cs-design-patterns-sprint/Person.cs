using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{

    public partial class Person
    {
        public readonly string FirstName;
        public readonly string LastName;
        public readonly int Age;
        public readonly string Address;
        public readonly string PhoneNumber;
        public readonly string Email;

        public Person(string firstName, string lastName, int age, string address, string phoneNumber, string email)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("First and last name cannot be null or empty");
            }
            if (age <= 0)
            {
                throw new ArgumentException("Age must be a positive integer");
            }

            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid UK phone number");
            }

            if (!ValidateEmail(email))
            {
                throw new ArgumentException("Invalid email address");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"Person{{firstName='{FirstName}', lastName='{LastName}', age={Age}, address='{Address}', phoneNumber='{PhoneNumber}', email='{Email}'}}";
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            // use the GeneratedRegex attribute to validate a phone number efficiently
            var regex = UKMobileRegex();
            return regex.IsMatch(phoneNumber);
        }

        public static bool ValidateEmail(string email)
        {            
            var regex = EmailRegex();
            return regex.IsMatch(email);
        }

        // NOTE: Regex (or regular expressions) can look a bit terrifying
        // but they can be handy to validate complex strings like emails or phone numbers
        // Don't worry about understanding or optimising this code - just trust that
        // calling `EmailRegex().IsMatch(someString)` will give us a bool that validates
        // the email matches the pattern specified below

        // UK mobile phone numbers start 07 and then have 9 digits
        // Note this will fail to match most UK numbers, but 07XXXXXXXXX is fine for our purposes here
        [GeneratedRegex(@"07\d{9}")]
        private static partial Regex UKMobileRegex();

        // this will validate an email (not all possible formats, but simple emails should be fine!)
        [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        private static partial Regex EmailRegex();
    }
}
