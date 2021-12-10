using System;
using System.Text;
using System.IO;
using System.Collections.Generic;


namespace Test2
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phoneNumber;

        public string FirstName { get { return this._firstName; } set { this._firstName = value; } }
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        public Contact() { }
        public Contact(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n", FirstName, LastName, PhoneNumber, Email);
        }
    }
    class Program
    {
        
            
    }

    
}
