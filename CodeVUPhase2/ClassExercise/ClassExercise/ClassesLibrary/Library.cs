using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Library
    {
        private List<Book> _books;
        private string _libraryName;
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;

        public List<Book> Books { get { return _books; } set { _books = value; } }
        public string LibraryName { get { return _libraryName; } set { _libraryName = value; } }
        public string StreetAddress { get { return _streetAddress; } set { _streetAddress = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string State { get { return _state; } set { _state = value; } }
        public string Zip { get { return _zip; } set { _zip = value; } }

        public Library() { }
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            return string.Format("Books: {0}\nLibrary Name: {1}\n" +
                "Street Address: {2}\nCity: {3}\n" +
                "State: {4}\nZip: {5}", Books, LibraryName, StreetAddress, City, State, Zip);
        }


    }
}
