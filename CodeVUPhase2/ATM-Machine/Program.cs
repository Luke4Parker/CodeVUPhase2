using System;
using System.Globalization;

namespace Lab4
{
    class Account
    {
        private string _name;
        private string _accountNum;
        private string _pin;
        private decimal _balance;
        public string Name { get { return _name; } set { _name = value; } }
        public string AccountNum { get { return _accountNum; } set { _accountNum = value; } }
        public string Pin { get { return _pin; } set { _pin = value; } }
        public decimal Balance { get { return _balance; } set { _balance = value; } }

        public Account()
        {
            Name = "";
            AccountNum = "";
            Pin = "";
            Balance = 0.0m;
        }
        public Account(string name, string accountNum, string pin, decimal balance)
        {
            Name = name;
            AccountNum = accountNum;
            Pin = pin;
            Balance = balance;
        }
        public Account(Account newAccount)
        {
            Name = newAccount.Name;
            AccountNum = newAccount.AccountNum;
            Pin = newAccount.Pin;
            Balance = newAccount.Balance;
        }
        public override string ToString()
        {
            return string.Format("Account Name: {0}\nAccount Number: {1}\nPin: {2}\nBalance", Name, AccountNum, Pin, Balance);
        }

    }
    class Program
    {
        

        static void Main(string[] args)
        {
            string accountNum = "123456";
            string pinNum = "54321";
            decimal accountBal = 0.0m;

            Console.WriteLine("Enter a menu selection: 1 for login to existing account, 2 for create new account, 3 for exit");
            string userMenuSelect = Console.ReadLine();


            switch (userMenuSelect)
            {
                case "1":
                    break;
                case "2":
                    Account newAccount = new Account(CreateAccount());
                    
                    accountNum = newAccount.AccountNum;
                    pinNum = newAccount.Pin;
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. I quit.");
                    return;

            }


            Console.WriteLine("Enter your account number: ");
            if (!ValidateLogin(accountNum))
            {
                Console.WriteLine("You are locked out of your account");
                return;
            }
            Console.WriteLine("Enter your pin number: ");
            if (!ValidateLogin(pinNum))
            {
                Console.WriteLine("You are locked out of your account");
                return;
            }

            while (true)
            {
                Console.WriteLine("Enter a menu selection: 1 for deposit, 2 for withdrawal, 3 for check balance, 4 for exit");
                userMenuSelect = Console.ReadLine();
                bool userExit = false;
                try
                {
                    switch (userMenuSelect)
                    {
                        case "1": //deposit
                            accountBal = MakeDeposit(accountBal, accountNum);
                            break;
                        case "2": // withdrawal
                            accountBal = MakeWithdrawal(accountBal, accountNum);
                            break;
                        case "3": //check balance
                            Console.WriteLine("Your balance is: {0:C2}", accountBal);
                            break;
                        case "4": //exit
                            Console.WriteLine("Thank you for business");
                            userExit = true;
                            break;
                        default:
                            Console.WriteLine("Bad input!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You need to enter a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number entered was too big");
                }
                
                

                if (userExit == true)
                {
                    break;
                }
            }

        }
        static bool ValidateLogin(string loginCredential)
        {
            bool success = false;
            int lockoutCount = 0;
            while (lockoutCount < 3)
            {

                string userAcctInput = Console.ReadLine();
                if (userAcctInput == loginCredential)
                {
                    success = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry :( ");
                    lockoutCount++;
                }
            }
            return success;
        }

        static Account CreateAccount()
        {
            Account temp = new Account();
            Random random = new Random();

            Console.WriteLine("Enter your name: ");
            temp.Name = Console.ReadLine();
            temp.AccountNum = random.Next(100000, 999999).ToString();
            Console.WriteLine("Your account number is {0}", temp.AccountNum);
            Console.WriteLine("Enter a pin: ");
            temp.Pin = Console.ReadLine();
            temp.Balance = 0.00m;
            Console.WriteLine("");

            return temp;

        }

        static decimal MakeDeposit(decimal balance, string account)
        {
            Console.WriteLine("How much would you like to deposit? ");
            decimal depositAmt = decimal.Parse(Console.ReadLine());
            balance += depositAmt;
            Console.WriteLine("{0:C2} has been deposited into account number {1}\n" +
                "Your new balance is: {2:C2}", depositAmt, account, balance);
            return balance;
        }

        static decimal MakeWithdrawal(decimal balance, string account)
        {
            Console.WriteLine("How much would you like to withdraw? ");            
            decimal withdrawAmt = decimal.Parse(Console.ReadLine());
            if (withdrawAmt > balance)
            {
                Console.WriteLine("You do not have that much money.");
                return balance;
            }
            balance -= withdrawAmt;
            Console.WriteLine("{0:C2} has been withdrawn from account number {1}\n" +
                "Your new balance is: {2:C2}", withdrawAmt, account, balance);
            return balance;
        }
    }
}
