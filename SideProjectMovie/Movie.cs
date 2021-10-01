using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectMovie
{
    public class Movie : Interface1
    {
        //properties
        public string Title { get; set; }
        public string Director { get; set; } = "unknown";
        public string Date { get; set; } = "unknown";
        public List<string> Actors { get; set; }
        public int Length { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; } = "unknown";
        public bool BookFirst { get; set; }
        public string Rating { get; set; } //R, PG-13, PG
        public string MyRating { get; set; }
        public bool areSequals { get; set; }
        //public int TomatoMeter { get; set; }
        //can i generate propeties with methods so that I can add them...

        //constuctor
        public Movie(string title )
        {
            Title = title;
        }
        //methods
        public void GetDirector (string directorName)
        {
            Director = directorName;
        }
        public void Book(bool wasBook)
        {
            BookFirst = wasBook;
        }

    }
}
