using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        private int _accountNumber;
        private Customer _customerInfo;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        public int AccountNumber { get { return _accountNumber; } set { _accountNumber = value; } }
        public Customer CustomerInfo { get { return _customerInfo; } set { _customerInfo = value; } }
        public decimal Balance { get { return _balance; } set { _balance = value; } }
        public bool IsPastDue { get { return _isPastDue; } set { _isPastDue = value; } }
        public decimal AnnualInterestRate { get { return _annualInterestRate; } set { _annualInterestRate = value; } }

        public CreditCardAccount() { }
        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public override string ToString()
        {
            return string.Format("Account Number: {0}\nCustomer Info: {1}" +
                "\nBalance: {2}\nPast Due?: {3}\n" +
                "Interest Rate: {4}", AccountNumber, CustomerInfo, Balance, IsPastDue, AnnualInterestRate);
        }
    }
}
