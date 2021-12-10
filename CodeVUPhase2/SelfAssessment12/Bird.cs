using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment12
{
    public class Bird : Animal
    {
        public Bird(int age, string name, bool male) : base(age, name, male)
        { }

        public override string MakeSound()
        {
            return "Cheep!!!";
        }
    }
}