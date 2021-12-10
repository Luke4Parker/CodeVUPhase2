namespace SelfAssessment12
{
    public class Kitten : Animal
    {
        public Kitten(int age, string name, bool male) : base(age, name, male)
        { }

        public override string MakeSound()
        {
            return "Mew PurrPurr!";
        }
    }
}
