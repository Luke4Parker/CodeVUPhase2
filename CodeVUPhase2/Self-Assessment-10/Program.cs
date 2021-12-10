using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Self_Assessment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            CountTheWords();
        }
        static void QuestionOne()
        {
            List<int> intList = new List<int>();
            int sum = 0;
            int count = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a positive integer. Press enter when done.");
                    string strInput = Console.ReadLine();
                    if (strInput == "")
                    {
                        break;
                    }
                    else
                    {
                        int input = int.Parse(strInput);
                        if (input < 0)
                        {
                            Console.WriteLine("You fool! You entered a negative integer!");
                        }
                        else
                        {
                            intList.Append(input);
                            sum += input;
                            count++;
                        }
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a positive integer");
                }

            }
            int average = sum / count;
            Console.WriteLine("Sum: " + sum + "\nAverage: " + average);
        }
        static void FindTheMajorant()
        {
            int[] intArr = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int maxCount = 0;
            int index = -1;

            for (int i = 0; i < intArr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < intArr.Length; j++)
                {
                    if (intArr[i] == intArr[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    index = i;
                }
            }
            int majorant = (intArr.Length / 2) + 1;
            if (maxCount >= majorant)
            {
                Console.WriteLine("The Majorant is " + intArr[index]);
            }
            else
            {
                Console.WriteLine("There is no majronmasnt");
            }
        }
        static void NumOfOccurences()
        {
            IDictionary<int, int> numOfOccurences = new Dictionary<int, int>();
            int[] intArr = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            for (int i = 0; i < intArr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < intArr.Length; j++)
                {
                    if (intArr[i] == intArr[j])
                    {
                        count++;
                    }
                }
                if (!numOfOccurences.ContainsKey(intArr[i]))
                {
                    numOfOccurences.Add(intArr[i], count);
                }
            }

            foreach (KeyValuePair<int, int> pair in numOfOccurences)
            {
                Console.WriteLine("Number: " + pair.Key + "\nValue: " + pair.Value);
            }
        }
        static void RemoveTheOddOccurences()
        {
            int[] intArr = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            List<int> oddOccurences = new List<int>();


            for (int i = 0; i < intArr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < intArr.Length; j++)
                {
                    if (intArr[i] == intArr[j])
                    {
                        count++;
                    }
                }
                if (count % 2 == 0)
                {
                    oddOccurences.Add(intArr[i]);
                }
            }
            foreach (int num in oddOccurences)
            {
                Console.Write(num + " ");
            }
        }
        static void CountTheWords()
        {
            IDictionary<string, int> WordCounts = new Dictionary<string, int>();
            string filepath = "C:/Git/CodeVUPhase2/CodeVUPhase2/CodeVUPhase2/Test2/TextFile1.txt";
            string test = File.ReadAllText(filepath);
            string[] strArr = test.Split(" ");
            List<string> strippedWords = new List<string>();
            int numWords = 0;


            foreach (string item in strArr)
            {
                string newItem;
                if (char.IsPunctuation(item[item.Length - 1]))
                {
                    newItem = item.Remove(item.Length - 1);
                    newItem = newItem.ToLower();
                    newItem.Trim();
                    if (newItem != "")
                    {
                        strippedWords.Add(newItem);
                        numWords++;
                    }
                }
                else
                {
                    newItem = item;
                    newItem = newItem.ToLower();
                    newItem.Trim();
                    if (newItem != "")
                    {
                        strippedWords.Add(newItem);
                        numWords++;
                    }
                }
            }

            foreach (string word in strippedWords)
            {
                Console.WriteLine(word);
            }
            for (int i = 0; i < numWords; i++)
            {
                int count = 0;
                for (int j = 0; j < numWords; j++)
                {
                    if (strippedWords[i] == strippedWords[j])
                    {
                        count++;
                    }
                }

                if (!WordCounts.ContainsKey(strippedWords[i]))
                {
                    WordCounts.Add(strippedWords[i], count);
                }

            }

            foreach (KeyValuePair<string, int> pair in WordCounts)
            {
                Console.WriteLine(pair.Key + " | " + pair.Value);
            }
        }
    }
}
