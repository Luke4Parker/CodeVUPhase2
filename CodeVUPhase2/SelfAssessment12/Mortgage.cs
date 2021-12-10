namespace SelfAssessment12
{
    public class Mortgage : Account
    {
        public Mortgage(decimal balance, decimal rate, Customer customer) : base(balance, rate, customer)
        { }

        public override decimal CalcInterest(decimal months)
        {
             months -= 6;
             return Balance * Rate * months;           
        }
    }
}
