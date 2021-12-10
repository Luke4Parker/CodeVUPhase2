namespace SelfAssessment12
{
    public class Loan : Account
    {
        public Loan(decimal balance, decimal rate, Customer customer) : base(balance, rate, customer)
        { }

        public override decimal CalcInterest(decimal months)
        {
            if(Customer.IsCompany)
            {
                months -= 2m;
            }
            else
            {
                months -= 3m;
            }
            return Balance * Rate * months;
        }
    }
}
