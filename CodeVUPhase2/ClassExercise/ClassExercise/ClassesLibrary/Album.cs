using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Album
    {
        private Song[] _tracks;
        private string _title;
        private string _genre;

        public Song[] Tracks { get { return _tracks; } set { _tracks = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Genre { get { return _genre; } set { _genre = value; } }

        public Album() { }
        public Album(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        public override string ToString()
        {
            return string.Format("Tracks: {0}\nTitle: {1}\nGenre: {2}\n", Tracks, Title, Genre);
        }
    }
}
