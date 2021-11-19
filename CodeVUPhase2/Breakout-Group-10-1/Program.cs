using System;

namespace Breakout_Group_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input the length of the array");
            //int arrayLength = int.Parse(Console.ReadLine());
            //int[] testArray = new int[arrayLength];
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    Console.WriteLine("Input Number:");
            //    testArray[i] = int.Parse(Console.ReadLine());
            //}
            //int lastNum = testArray[0];
            //bool returnVal = false;
            //for (int i = 0; i < arrayLength - 2; i++)
            //{
            //    if ((testArray[i] - testArray[i + 1] == -1) && (testArray[i + 1] - testArray[i + 2] == -1))
            //    {
            //        returnVal = true;
            //    }

            //}
            //Console.WriteLine(returnVal);

            /**************/
            //Exercise 2

            Console.WriteLine("Scoring Guide");
            float[,] gradeArr = new float[2, 10];


            for (int classNum = 0; classNum < 2; classNum++)
            {
                for (int studNum = 0; studNum < 10; studNum++)
                {
                    Console.WriteLine("Input Class {0} Student {1}'s grade", (classNum + 1), (studNum + 1));
                    gradeArr[classNum, studNum] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (int classNum = 0; classNum < 2; classNum++)
            {
                float totalPoints = 0.0f;
                for (int studNum = 0; studNum < 10; studNum++)
                {
                    totalPoints += gradeArr[classNum, studNum];
                }
                Console.WriteLine("Average grade for Class {0} was {1}", (classNum + 1), (totalPoints / 10));
            }



        }
    }
}
