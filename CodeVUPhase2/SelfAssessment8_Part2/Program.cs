using System;
using System.Collections.Generic;

namespace SelfAssessment8_Part2
{
    public class Call
    {
        public string Date { get; set; }
        public string StartTime { get; set; }
        public double Duration { get; set; }

        public Call() 
        {
        }
        public Call(string date, string startTime, double duration)
        {
            Date = date;
            StartTime = startTime;
            Duration = duration;
        }

        public override string ToString()
        {
            return string.Format("Call Date: {0} Call Start Time: {1} Call Duration: {2}", Date, StartTime, Duration);
        }
    }
    public class Phone
    {
        private string _model;
        private string _manufacturer;
        private string _price;
        private string _owner;
        private string _battModel;
        private string _battSize;
        private string _battTalkTime;
        private string _screenSize;
        private string _screenType;
        private List<Call> _callHistory;
        private static Phone nokiaN95 = new Phone("N95", "Nokia", "Spensive", "Me", "Nokia", "Big", "LongTalk", "also Big", "Pretty");
        public enum BatteryType
        {
            LiIon, NiHM, NiCd
        }
        private BatteryType bType;
        
        public string Model { get { return this._model; } set { this._model = value; } }
        public string Manufacturer { get { return this._manufacturer; } set { this._manufacturer = value; } }
        public string Price { get { return this._price; } set { this._price = value; } }
        public string Owner { get { return this._owner; } set { this._owner = value; } }
        public string BattModel { get { return this._battModel; } set { this._battModel = value; } }
        public string BattSize { get { return this._battSize; } set { this._battSize = value; } }
        public string BattTalkTime { get { return this._battTalkTime; } set { this._battTalkTime = value; } }
        public string ScreenSize { get { return this._screenSize; } set { this._screenSize = value; } }
        public string ScreenType { get { return this._screenType; } set { this._screenType = value; } }
        public List<Call> CallHistory { get { return this._callHistory; } set { this._callHistory = value; } }

        public Phone()
        {
            Model = null;
            Manufacturer = null;
            Price = null;
            Owner = null;
            BattModel = null;
            BattSize = null;
            BattTalkTime = null;
            ScreenSize = null;
            ScreenType = null;
            CallHistory = new List<Call>();
        }
        public Phone(string model, string manufacturer, string price, string owner, string battModel, string battSize, string battTalkTime, string screenSize, string screenType)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            BattModel = battModel;
            BattSize = battSize;
            BattTalkTime = battTalkTime;
            ScreenSize = screenSize;
            ScreenType = screenType;
            CallHistory = new List<Call>();
        }
        
        public void PrintCallHistory()
        {
            int i = 1;
            foreach(Call call in CallHistory)
            {
                Console.Write(i + ". ");
                Console.WriteLine(call);
                i++;
            }
        }
        public void AddCall()
        {
            string date, time;
            double duration;

            Console.WriteLine("Add a new call to the history");
            Console.WriteLine("Enter the date of the call: ");
            date = Console.ReadLine();
            Console.WriteLine("Enter the time of the call: ");
            time = Console.ReadLine();
            Console.WriteLine("Enter the duration of the call in seconds: ");

            while (true)
            {
                try
                {
                    duration = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a double for duration");
                } 
            }
            Call temp = new Call(date, time, duration);
            CallHistory.Add(temp);
        }
        public void DeleteCall()
        {
                       
            int i;
            PrintCallHistory();
            Console.WriteLine("Enter the index of the call you wish to delete");
            while (true)
            {
                try
                {
                    i = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter an int");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Enter an available index");
                } 
            }

            CallHistory.RemoveAt(i - 1);
        }
        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public void TotalCallCost(double costPerMinute)
        {
            double cost = 0.00;
            double totalMinutes = 0.00;
            foreach (Call call in CallHistory)
            {
                totalMinutes += call.Duration;
            }
            cost = (totalMinutes / 60) * costPerMinute;
            Console.WriteLine("Your total call cost is: "+cost);
        }
        public static string DisplayNokiaN95()
        {
            nokiaN95.bType = BatteryType.NiCd;
            return nokiaN95.ToString() + nokiaN95.bType;
        }
        public override string ToString()
        {
            return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattModel: {4}\nBattSize: {5}\nBattTalkTime: {6}\nScreenSize: {7}\nScreenType: {8}\n",Model, Manufacturer, Price, Owner, BattModel, BattSize,BattTalkTime,ScreenSize,ScreenType);
        }


    }
    public class PhoneTest
    {
        public Phone Phone { get; set; }

        public PhoneTest()
        {
            Phone phone1 = new Phone("Moto Z3", "Motorola","Expensive", "Me", "MotoBatts", "4000mhz", "Long Talk Time", "Big", "Not OLED");
            Phone phone2 = new Phone();
            Phone[] phones = new Phone[2];
            phones[0] = phone1;
            phones[1] = phone2;

            foreach (Phone phone in phones)
            {
                Console.WriteLine(phone);
            }
        }

    }
    public class PhoneCallTest
    {
        public PhoneCallTest()
        {
            Phone phone = new Phone();
            phone.AddCall();
            phone.AddCall();
            phone.AddCall();
            phone.AddCall();

            foreach (Call call in phone.CallHistory)
            {
                Console.WriteLine(call);
            }

            phone.TotalCallCost(.37);
            phone.DeleteCall();
            phone.TotalCallCost(.37);
            phone.ClearCallHistory();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Phone.DisplayNokiaN95());
        }
    }
}
