using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        public string FirstName 
        {
          get { return _firstName; }
          set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public Student() { }

        public Student(string firstName = "", string lastName = "", string id = "", float gpa = 0.0f)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}\nLast Name: {1}\nStudent ID: {2}\nGPA: {3}", FirstName, LastName, Id, Gpa);
        }
    }
}
