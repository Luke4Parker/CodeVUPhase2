namespace SelfAssessment12
{
    public class Dog : Animal
    {
        public Dog(int age, string name, bool male) : base(age, name, male)
        { }

        public override string MakeSound()
        {
            return "Woof!";
        }
    }
}
