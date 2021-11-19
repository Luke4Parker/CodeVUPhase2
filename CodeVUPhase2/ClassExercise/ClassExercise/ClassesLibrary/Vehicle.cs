using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Vehicle
    {
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        public string Make 
        { 
            get { return _make; } 
            set { _make = value; } 
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Vehicle() { }
        public Vehicle(string make = "", string model = "", int year = 0, float weight = 0.0f)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("Make: {0}\nModel: {1}\nYear: {2}\nWeight: {3}", Make, Model, Year, Weight);
        }
    }
}
