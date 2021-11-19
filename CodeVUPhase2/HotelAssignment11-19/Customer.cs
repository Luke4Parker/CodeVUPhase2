using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAssignment11_19
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CreditCardNum { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string firstname, string lastname, DateTime dateofbirth, string creditcardnum, string phone)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.DateOfBirth = dateofbirth;
            this.CreditCardNum = creditcardnum;
            this.PhoneNumber = phone;
        }

        public string ReturnCCLastFour()
        {
            string lastFour = "xxxxxxxxxxxx" + CreditCardNum.Substring(12, 4);
            return lastFour;
        }
        public override string ToString()
        {
            return string.Format($"\nCustomer Name: {FirstName} {LastName}\nDate of Birth: {DateOfBirth.Date}\nCredit Card Number: {ReturnCCLastFour()}");
        }

        
    }
}
