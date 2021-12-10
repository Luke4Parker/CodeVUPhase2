namespace SelfAssessment12
{
    public abstract class Account
    {
        public decimal Balance { get; set; }
        public decimal Rate { get; set; }
        public Customer Customer { get; set; }

        public Account(decimal balance, decimal rate, Customer customer)
        {
            Balance = balance;
            Rate = rate;
            Customer = customer;
        }

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
        }

        public virtual decimal CalcInterest(decimal months)
        {
            return Balance * Rate * months;
        }

        public override string ToString()
        {
            return string.Format($"Account Holder: {this.Customer.Name}\nAccount Balance: {this.Balance}\nAccount Rate: {this.Rate}");
        }

    }
}
