using System;
using System.Collections.Generic;

namespace SelfAssessment9_GenericList
{
    public class GenericList<T>
    {
        public T[] GenList;
        private static int itemsAdded = 0;

        public static int ItemsAdded { get => itemsAdded; set => itemsAdded = value; }

        public GenericList(int i)
        {
            GenList = new T[i];
        }
        public void AddItem(T item)
        {
            if (ItemsAdded == GenList.Length)
            {
                GenericList<T> tempList = new GenericList<T>(GenList.Length + 1);
                int index = 0;
                foreach (T listItem in this.GenList)
                {
                    tempList.GenList[index] = this.GenList[index];
                    index++;
                }
                this.GenList = tempList.GenList;
            }
            for (int i = ItemsAdded; i < GenList.Length; i++)
            {
                if (ItemsAdded == i)
                {
                    GenList[i] = item;
                    break;
                }

            }

            ItemsAdded++;
        }
        public void RemoveItem(int index)
        {
            GenericList<T> tempList = new GenericList<T>(GenList.Length - 1);
            int i = 0;
            int offset = 0;
            foreach (T listItem in tempList.GenList)
            {
                if (i == index)
                {
                    offset++;
                    tempList.GenList[i] = this.GenList[i + offset];
                }
                else
                {
                    tempList.GenList[i] = this.GenList[i + offset];
                }
                
                i++;
            }
            this.GenList = tempList.GenList;
            ItemsAdded--;
        }
        public void InsertItemAtIndex(T item, int index)
        {
            GenericList<T> tempList = new GenericList<T>(GenList.Length + 1);
            int i = 0;
            int offset = 0;
            foreach (T listItem in tempList.GenList)
            {
                if (i == index)
                {
                    offset++;
                    tempList.GenList[i] = item;
                }
                else
                {
                    tempList.GenList[i] = this.GenList[i - offset];
                }

                i++;
            }
            this.GenList = tempList.GenList;
            ItemsAdded++;
        }
        public T IndexSearch(int index)
        {
            return this.GenList[index];
        }
        public int ValueSearch(T item)
        {
            return Array.IndexOf(this.GenList, item);
        }
        public void ClearList()
        {
            this.GenList = new T[0];
            ItemsAdded = 0;
        }
        public override string ToString()
        {
            string itemsInList = "";
            foreach (T item in this.GenList)
            {
                itemsInList += item;
            }

            return itemsInList;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> numList = new GenericList<int>(3);
            numList.AddItem(1);
            numList.AddItem(2);
            numList.AddItem(3);
            numList.AddItem(4);
            numList.AddItem(5);
            numList.AddItem(6);
            numList.AddItem(7);
            numList.RemoveItem(6);
            numList.AddItem(8);
            numList.InsertItemAtIndex(9, 3);
            numList.ClearList();
            Console.WriteLine("List Cleared");
            numList.AddItem(1);
            Console.WriteLine(numList.ToString()); 
            

            foreach (int num in numList.GenList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Index of 8");
            Console.WriteLine(numList.ValueSearch(10));

            
            
        }
    }
}
