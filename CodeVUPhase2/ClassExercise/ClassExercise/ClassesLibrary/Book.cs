using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Book
    {
        public string _title;
        public string _author;
        public int _numberOfPage;

        public string Title { get { return _title; } set { _title = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public int NumberOfPage { get { return _numberOfPage; } set { _numberOfPage = value; } }

        public Book() { }
        public Book(string title, string author, int numberOfPage)
        {
            Title = title;
            Author = author;
            NumberOfPage = numberOfPage;
        }

        public override string ToString()
        {
            return string.Format("Title: {0}\nAuthor: {1}\nNumber of Pages: {2}", Title, Author, NumberOfPage);
        }
    }
}
