namespace SelfAssessment12
{
    public class Cat : Animal
    {
        public Cat(int age, string name, bool male) : base(age, name, male)
        { }

        public override string MakeSound()
        {
            return "Mrowrrr HissHiss!";
        }
    }
}
