using System;
using System.Collections.Generic;
using System.Collections;


namespace InClassDec3
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, List<decimal>> Morty = new Dictionary<string, List<decimal>>();
            IDictionary<string, List<decimal>> Charlie = new Dictionary<string, List<decimal>>();
            IDictionary<string, List<decimal>> Opie = new Dictionary<string, List<decimal>>();

            Morty.Add("homework", new List<decimal>() { .8m, .75m, .5m });
            Morty.Add("quizzes", new List<decimal>() { .95m, .75m, .8m });
            Morty.Add("tests", new List<decimal>() { .70m, .75m, .8m });


            Charlie.Add("homework", new List<decimal>() { .8m, .75m, .5m });
            Charlie.Add("quizzes", new List<decimal>() { .95m, .90m, .73m });
            Charlie.Add("tests", new List<decimal>() { .70m, .75m, .5m });


            Opie.Add("homework", new List<decimal>() { .8m, .75m, .5m });
            Opie.Add("quizzes", new List<decimal>() { .8m, .75m, .5m });
            Opie.Add("tests", new List<decimal>() { .8m, .75m, .5m });

            Dictionary<string, Dictionary<string, List<decimal>>> studentList = new Dictionary<string, Dictionary<string, List<decimal>>>();

            studentList.Add("Morty", (Dictionary<string, List<decimal>>)Morty);
            studentList.Add("Charlie", (Dictionary<string, List<decimal>>)Charlie);
            studentList.Add("Opie", (Dictionary<string, List<decimal>>)Opie);

            PrintStudentInfo(studentList);


        }
        static void PrintStudentInfo(Dictionary<string, Dictionary<string, List<decimal>>> student)
        {
            foreach (KeyValuePair<string, Dictionary<string, List<decimal>>> MainKeyValue in student)
            {
                Console.WriteLine(MainKeyValue.Key);
                foreach (KeyValuePair<string, List<decimal>> kv in MainKeyValue.Value)
                {
                    Console.WriteLine($"Key: {kv.Key}\nValues: ");
                    foreach (decimal grade in kv.Value)
                    {
                        Console.WriteLine($"{grade}");

                    }
                }
            }
        }
    }
}


