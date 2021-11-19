using System;
using System.Collections.Generic;
using System.Text;


namespace ClassesLibrary
{
    public class Customer
    {
        //customerId, firstName, lastName, contactInformation (ContactInfo class)

        private string _customerId;
        private string _firstName;
        private string _lastName;
        private ContactInfo _contactInformation;

        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public ContactInfo ContactInformation
        {
            get { return _contactInformation; }
            set { _contactInformation = value; }
        }

        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        public Customer() { }

        public override string ToString()
        {
            return string.Format("Customer Id: {0}\nFirst: {1}\nLast: {2}\nContact Information: {3}", CustomerId, FirstName, LastName, ContactInformation);
        }
    }
}
