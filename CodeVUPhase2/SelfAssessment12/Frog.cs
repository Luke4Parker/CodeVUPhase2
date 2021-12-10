namespace SelfAssessment12
{
    public class Frog : Animal
    {
        public Frog(int age, string name, bool male) : base(age, name, male)
        { }

        public override string MakeSound()
        {
            return "Ribbit!";
        }
    }
}
