//This project is to try out shtuff. Not actual assignment answers            

using System;
using System.Collections.Generic;
using System.IO;


namespace Test_Project
{
    public class TestClass
    {
        private int _test;

        public int Test { get => _test; set => _test = value; }
    }
    public class Meeting
    {
        private string title;
        private string location;
        private DateTime startDateTime;
        private DateTime endDateTime;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTime;
            }
            set
            {
                this.startDateTime = value;
            }
        }

        public DateTime EndDateTime
        {
            get
            {
                return this.endDateTime;
            }
            set
            {
                this.endDateTime = value;
            }
        }
        public Meeting() { }
        public Meeting(string title, string location, DateTime startTime, DateTime endTime)
        {
            Title = title;
            Location = location;
            StartDateTime = startTime;
            EndDateTime = endTime;
        }
        public override string ToString()
        {
            return string.Format("{0} from {1} to {2} | {3} at {4}", StartDateTime.ToString("MM/dd"), StartDateTime.ToString("HH:mm"), EndDateTime.ToString("HH:mm"), Title, Location);
        }
    }
    public class BadInputException : Exception
    {
        public BadInputException() { }
        public BadInputException(string message) : base(message) { }
        public BadInputException(string message, Exception inner) : base(message, inner) { }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Meeting> calendar = new List<Meeting>();
            List<Meeting> loadCalendar = new List<Meeting>();
            DateTime date;
            int intInput;
            string strInput;
            string filepath = "C:/Git/CodeVUPhase2/CodeVUPhase2/CodeVUPhase2/Test-Project/testFile.dat";
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the date for your calendar in format mm/dd/yyyy: ");
                    strInput = Console.ReadLine();
                    date = DateTime.Parse(strInput + " 8:00");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect date format. Please enter in mm/dd/yyyy");
                }
            }

            for (int i = 0; i < 9; i++)
            {
                calendar.Add(new Meeting("Free", "N/A", date, date.AddMinutes(60)));
                date = date.AddMinutes(60);
            }
            int index = 1;
            foreach (Meeting testMeet in calendar)
            {
                Console.Write(index + ". ");
                Console.WriteLine(testMeet);
                index++;
            }

            Console.WriteLine("Enter the timeslot you want to add a meeting to: ");
            while (true)
            { try
                {
                    intInput = int.Parse(Console.ReadLine());
                    if (intInput < 1 || intInput > 9)
                    {
                        throw new BadInputException();
                    }
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter an int");
                }
                catch (BadInputException)
                {
                    Console.WriteLine("You didn't select an appropriate timeslot");
                }
            }

                      
            Console.WriteLine("Enter the title of the meeting: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the location of the meeting: ");
            string location = Console.ReadLine();            
            

            calendar[intInput - 1].Title = title;
            calendar[intInput - 1].Location = location;

            using (StreamWriter writer = new StreamWriter(filepath))
            {
                foreach (Meeting testMeet in calendar)
                {
                    writer.WriteLine(testMeet.Title + ',' + testMeet.Location + ',' + testMeet.StartDateTime.ToString() + ',' + testMeet.EndDateTime.ToString());
                }
            }
            string line = "";

            Console.WriteLine("Loaded contents of test file\n");
            using (StreamReader reader = new StreamReader(filepath))
            {
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] dateHolder = line.Split(',');
                    loadCalendar.Add(new Meeting(dateHolder[0], dateHolder[1], DateTime.Parse(dateHolder[2]), DateTime.Parse(dateHolder[3])));
                }
            }
            foreach (Meeting testMeet in loadCalendar)
            {
                Console.WriteLine(testMeet);
            }




        }
    }

}
