using System;
using System.IO;
using System.Net;

namespace Self_Assessment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuestionSeven();

            //Question 8
            //try
            //{
            //    Console.WriteLine("Enter an int to start the range: ");
            //    int start = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter an int to end the range: ");
            //    int end = int.Parse(Console.ReadLine());
            //    ReadNumber(start, end);
            //}
            //catch (FormatException fe)
            //{
            //    Console.WriteLine("Input is not in the int format");
            //}

            //Question 9
            //Console.WriteLine("Input a filename for me to open");
            //string filename = Console.ReadLine();
            //string content = QuestionNine(filename);
            //Console.WriteLine(content);

            //Question 13
            //QuestionThirteen();
        }
        static void QuestionSeven()
        {
            try
            {
                Console.WriteLine("Enter an integer and I'll give you its square root: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Exception negNum = new Exception();
                    throw negNum;
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(num));
                }
            }
            catch (FormatException notInt)
            {
                Console.WriteLine("Invalid Number");
            }
            catch (Exception negNum)
            {
                Console.WriteLine("Negative Number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
        static void ReadNumber(int start, int end)
        {

            if (start > end - 10)
            {
                Console.WriteLine("The range won't support 10 correct inputs");
            }

            int newNum = 0, prevNum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    prevNum = i + 1;
                }
                bool carryOn = true;
                do
                {

                    Console.WriteLine("Enter a number within the range");
                    newNum = int.Parse(Console.ReadLine());
                    if (newNum < start || newNum > end)
                    {
                        Console.WriteLine("Number not in range");
                    }
                    else
                    {
                        if (newNum <= prevNum)
                        {
                            Console.WriteLine("Number not in range");
                        }
                        else if (newNum >= end)
                        {
                            Console.WriteLine("Number not in range");
                        }
                        else
                        {
                            prevNum = newNum;
                            carryOn = true;
                        }
                    }
                    Console.WriteLine("Value of i: {0}", i);
                } while (!carryOn);

            }

        }
        static string QuestionNine(string fileName)
        {
            string content = "";
            string line = "a";
            try
            {
                TextReader reader = new StreamReader(fileName);
                while (line != null)
                {
                    line = reader.ReadLine();
                    content = content + line;
                }
                
                reader.Close();
                
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(
                    "The file '{0}' is not found.", fileName);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
            return content;

        }
        static void QuestionThirteen()
        {
            try
            {
                WebClient Client = new WebClient();
                Client.DownloadFile("https://introprogramming.info/wp-content/uploads/2017/08/csharp-book-nakov-en-v2013-cover.jpg", @"C:\Git\CodeVUPhase2\CodeVUPhase2\CodeVUPhase2\Self-Assessment-6\BookCover.jpg");
            }
            
            catch (WebException we)
            {
                Console.WriteLine(we.GetBaseException());                
            }
            finally
            {
                Console.WriteLine("Done");
            }

        }
    }
}
