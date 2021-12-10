namespace SelfAssessment12
{
    public class DepositAccount : Account
    {
        public DepositAccount(decimal balance, decimal rate, Customer customer) : base(balance, rate, customer)
        {}

        public void Withdraw(decimal withdrawAmt)
        {
            Balance -= withdrawAmt;
        }
        public override decimal CalcInterest(decimal months)
        {
            if(Balance >= 0m && Balance < 1000m)
            {
                Rate = 0m;
            }
            return Rate*Balance*months;
        }
    }
}
