using System;
using System.Collections.Generic;





namespace Self_Assessment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 4
            //Console.WriteLine("Days = " + (Environment.TickCount / 86400000));
            //Console.WriteLine("Hours = " + (Environment.TickCount / 3600000));
            //Console.WriteLine("Minutes = " + (Environment.TickCount / 60000));
            //********************************

            //Question 9
            //DateTime date = new DateTime();
            //List<DateTime> holidays = new List<DateTime>()
            //{
            //    holidays.Add(12, 25);
            //}
            Console.WriteLine("Enter date in mm/dd/yyyy format: ");
            string input = Console.ReadLine();
            string[] date1 = input.Split('/');
            Console.WriteLine("Enter date 2 in mm/dd/yyyy format: ");
            input = Console.ReadLine();
            string[] date2 = input.Split('/');
            

            

            //Question 10

            //Console.WriteLine("Enter numbers separated by spaces");
            //string input = Console.ReadLine();
            //string[] splitNums = input.Split(' ');
            //int total = 0;
            //foreach (string num in splitNums)
            //{
            //    total += Convert.ToInt32(num);
            //}

            //Console.WriteLine(total);

            //*****************************************

            //Question 11
            //Random rand = new Random();
            //string[] phrases = { "The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };
            //string[] stories = { "Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };
            //string[] firstName = { "Dayan", "Stella", "Hellen", "Kate" };
            //string[] lastName = { "Johnson", "Peterson", "Charls" };
            //string[] cities = { "London", "Paris", "Berlin", "New York", "Madrid" };

            //Console.WriteLine("{0} {1} {2} {3} {4}", phrases[rand.Next(4)], stories[rand.Next(5)], firstName[rand.Next(4)], lastName[rand.Next(3)], cities[rand.Next(5)]);

            
        }
    }
}
