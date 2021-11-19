using System;

namespace SelfAssessment8
{
    public class Student
    {
        private static int _studentNumber = 0;
        private string _name;
        private string _email;
        private string _phone;
        private string _university;
        private string _subject;
        private string _course;

        public string Name { get { return this._name; } set { this._name = value; } }
        public string Email { get { return this._email; } set { this._email = value; } }
        public string Phone { get { return this._phone; } set { this._phone = value; } }
        public string University { get { return this._university; } set { this._university = value; } }
        public string Subject { get { return this._subject; } set { this._subject = value; } }
        public string Course { get { return this._course; } set { this._course = value; } }

        public static int StudentNumber { get => _studentNumber; set => _studentNumber = value; }

        public Student() 
        {
            Name = null;
            Email = null;
            Phone = null;
            University = null;
            Subject = null;
            Course = null;
            StudentNumber++;
        }
        public Student(string name)
        {
            Name = name;
            Email = null;
            Phone = null;
            University = null;
            Subject = null;
            Course = null;
            StudentNumber++;
        }
        public Student(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
            University = null;
            Subject = null;
            Course = null;
            StudentNumber++;
        }
        public Student(string name, string email, string phone, string university, string subject, string course)
        {
            Name = name;
            Email = email;
            Phone = phone;
            University = university;
            Subject = subject;
            Course = course;
            StudentNumber++;
        }

        public override string ToString()
        {
            return string.Format("Student Name: {0}\nStudent Email: {1}\nStudent Phone: {2}\n" +
                "University: {3}\nSubject: {4}\nCourse: {5}",Name, Email, Phone, University, Subject, Course);
        }


    }

    public class StudentTest
    {
        private static Student _student1;
        private static Student _student2;
        private static Student _student3;

        private Student _student;
        public Student Student { get { return this._student; } set { this._student = value; } }

        public static Student Student1 { get => _student1; set => _student1 = value; }
        public static Student Student2 { get => _student2; set => _student2 = value; }
        public static Student Student3 { get => _student3; set => _student3 = value; }

        public StudentTest(string name, string email, string phone, string university, string subject, string course)
        {
            Student = new Student(name, email, phone, university, subject, course);
        }
        public StudentTest(string name, string email, string phone)
        {
            Student = new Student(name, email, phone);
            
        }
        public StudentTest()
        {
            Student = new Student();
        }

        public static void CreateStudentStaticFields()
        {
            Student1 = new Student("Joe", "Joe@gmail.com", "1234567890");
            Student2 = new Student("Bill", "Bill@gmail.com", "2234567890");
            Student3 = new Student("Bob", "Bob@gmail.com", "3234567890");
        }


        public override string ToString()
        {
            Console.WriteLine(Student);
            return base.ToString();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentTest.CreateStudentStaticFields();
            Console.WriteLine(StudentTest.Student1);
            Console.WriteLine(StudentTest.Student2);
            Console.WriteLine(StudentTest.Student3);
            Console.WriteLine("Number of Students: " + Student.StudentNumber);
        }
    }
}
