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

        private Person(string firstName, string lastName, int age, string address, string phoneNumber, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public class Builder
        {
            // TODO: include private fields here to match the Person class
            public string FirstName;
            public string LastName;
            public int Age;
            public string Address;
            public string PhoneNumber;
            public string Email;

            public Builder(string firstName, string lastName, int age)
            {
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                {
                    throw new ArgumentException("First and last name cannot be null or empty");
                }
                if (age <= 0)
                {
                    throw new ArgumentException("Age must be a positive integer");
                }

                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
            }

            // example of an optional parameter
            public Builder WithAddress(string address)
            {
                this.Address = address;
                return this;
            }

            public Builder WithPhoneNumber(string phoneNumber)
            {
                if (!ValidatePhoneNumber(phoneNumber))
                {
                    throw new ArgumentException("Invalid UK phone number");
                }
                this.PhoneNumber = phoneNumber;
                return this;
            }

            public Builder WithEmail(string email)
            {
                if (!ValidateEmail(email))
                {
                    throw new ArgumentException("Invalid email address");
                }
                this.Email = email;
                return this;
            }

            public Person Build()
            {
                return new Person(this.FirstName, this.LastName, this.Age, this.Address, this.PhoneNumber, this.Email);
            }
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
