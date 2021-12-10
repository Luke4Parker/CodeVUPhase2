using System;

namespace SelfAssessment12
{
    public class Student : Human, IComparable<Student>
    {
        public int Mark { get; set; }
        
        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return Mark.CompareTo(other.Mark);
        }
        
        public Student(string firstname, string lastname, int mark) : base(firstname, lastname)
        {
            Mark = mark;
        }
        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName} {Mark}");
        }
    }
}
