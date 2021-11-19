using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public ContactInfo()
        { }
        public ContactInfo(string streetAddress = "", string city = "", string state = "",
            string zip = "", string phone = "", string email = "")
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return string.Format("Street Address: {0}\nCity: {1}\nState: {2}\nZip Code: {3}\nPhone: {4}\nEmail: {5}", StreetAddress, City, State, Zip, Phone, Email);
        }
    }
}
