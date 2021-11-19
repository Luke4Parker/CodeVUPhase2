using System;

namespace Self_Assessment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2
            //****************************
            //int maxNumber = 0;
            //int placeHolder = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter an int value: ");
            //    int input = int.Parse(Console.ReadLine());
            //    maxNumber = GetMax(placeHolder, input);
            //    placeHolder = maxNumber;
            //}

            //Console.WriteLine(maxNumber);
            //*****************************

            //Exercise 3
            //*****************************
            //Console.Write("Enter a number and I'll print the English name of the last digit: ");
            //double input = double.Parse(Console.ReadLine());
            //PrintLastDigitName(input);

            //Exercise 11
            //*****************************
            while (BuildMenu()) ;
        }

        //Method for exercise 2
        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        //Method for exercise 3
        static void PrintLastDigitName(double tempNum)
        {
            double lastDigit = (tempNum % 10);
            switch (lastDigit)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }
        }

        //Methods for exercise 11

        
        static bool BuildMenu()
        {
            bool keepLooping = true;
            Console.WriteLine("Pick an operation by entering its number:\n1. " +
                "Reverse Digits\n2. Get Average\n3. Solve Equation");
            string input = Console.ReadLine();
            int choice;
            bool inputValid = int.TryParse(input, out choice);

            while (true)
            {
                //Input validation
                if (inputValid)
                {
                    if (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("Invalid input. Enter an int value between 1 and 3");
                        input = Console.ReadLine();
                        inputValid = int.TryParse(input, out choice);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter an int value between 1 and 3");
                    input = Console.ReadLine();
                    inputValid = int.TryParse(input, out choice);
                }
            }
            switch (choice)
            {
                case 1:
                    ReverseDigits();
                    break;
                case 2:
                    GetAverage();
                    break;
                case 3:
                    SolveEquation();
                    break;
            }

            Console.WriteLine("Perform another operation? Y/N");
            input = Console.ReadLine();
            char yesOrNo;
            inputValid = char.TryParse(input, out yesOrNo);
            while (!inputValid)
            {
                Console.WriteLine("Invalid input. Enter Y or N.");
                input = Console.ReadLine();
                inputValid = char.TryParse(input, out yesOrNo);
            }
            if (yesOrNo == 'N' || yesOrNo == 'n')
            {
                keepLooping = false;
            }
            return keepLooping;

        }
        static void ReverseDigits()
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            int num1;
            bool inputValid = int.TryParse(input, out num1);
            while (!inputValid)
            {
                Console.Write("Bad Input. Enter an integer: ");
                input = Console.ReadLine();
                inputValid = int.TryParse(input, out num1);
            }
            int lengthNum = num1;
            int counter = 0;

            while (lengthNum > 0)
            {
                lengthNum /= 10;
                counter++;
            }
            int[] reverseNum = new int[counter];
            for (int i = counter; i > 0; i--)
            {
                reverseNum[i - 1] = num1 % 10;
                num1 /= 10;
                Console.Write(reverseNum[i - 1]);
            }
            Console.WriteLine();

        }
        static void GetAverage()
        {
            Console.Write("Enter how many numbers you want to average: ");
            string input = Console.ReadLine();
            int numCount;
            bool inputValid = int.TryParse(input, out numCount);
            while (!inputValid)
            {
                Console.Write("Bad Input. Enter an integer: ");
                input = Console.ReadLine();
                inputValid = int.TryParse(input, out numCount);
            }
            int numTotal = 0;
            for (int i = 0; i < numCount; i++)
            {
                Console.Write("Enter an int: ");
                input = Console.ReadLine();
                int num;
                inputValid = int.TryParse(input, out num);
                while (!inputValid)
                {
                    Console.Write("Bad Input. Enter an integer: ");
                    input = Console.ReadLine();
                    inputValid = int.TryParse(input, out num);
                }
                numTotal += num;
                
            }
            double average = (double)numTotal / numCount;
            Console.WriteLine(average);
        }
        static void SolveEquation()
        {
            Console.WriteLine("a * x + b = 0 is solved to equal x = -b/a");
        }
    }
}
