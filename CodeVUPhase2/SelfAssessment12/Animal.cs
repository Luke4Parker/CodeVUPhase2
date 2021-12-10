namespace SelfAssessment12
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public bool Male { get; set; }

        public Animal(int age, string name, bool male)
        {
            Age = age;
            Name = name;
            Male = male;
        }

        public virtual string MakeSound()
        {
            return "Eblarghe!";
        }

        public string Gender()
        {
            if(Male)
            {
                return "Gender is male";
            }
            else
            {
                return "Gender is female";
            }
        }

        public override string ToString()
        {
            return string.Format($"{Age} {Name} {Gender()} {this.MakeSound()}");
        }
    }
}
