using System;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Chapter 11 Exercise";

            Console.WriteLine("***Student***");
            Student student1 = new Student("Ash", "Ketchum", "151", 1.4f);
            Student student2 = new Student();
            student2.FirstName = "Misty";
            student2.LastName = "Yama";
            student2.Id = "150";
            student2.Gpa = 3.9f;
            Console.WriteLine(student1);
            Console.WriteLine(student2);

        }
    }
}
