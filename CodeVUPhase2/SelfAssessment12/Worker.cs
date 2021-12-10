namespace SelfAssessment12
{
    public class Worker : Human
    {
        public decimal Wage { get; set; }
        public decimal HoursWorked { get; set; }

        public Worker(string firstname, string lastname, decimal wage, decimal hoursWorked) : base(firstname, lastname)
        {
            Wage = wage;
            HoursWorked = hoursWorked;
        }
        public decimal CalcHourlyWage()
        {
            decimal hourly = Wage / HoursWorked;
            return hourly;
        }
        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName} {CalcHourlyWage()}");
        }
    }
}
