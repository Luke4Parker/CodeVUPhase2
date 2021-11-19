using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Song
    {
        private string _artist;
        private string _title;
        private int _lengthInSeconds;

        public string Artist { get { return _artist; } set { _artist = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public int LengthInSeconds { get { return _lengthInSeconds; } set { _lengthInSeconds = value; } }

        public Song() { }
        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }

        public override string ToString()
        {
            return string.Format("Artist: {0}\nTitle: {1}\nLengthInSeconds: {2}", Artist,Title, LengthInSeconds);
        }
    }
}
