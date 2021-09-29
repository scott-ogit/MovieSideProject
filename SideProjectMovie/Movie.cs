using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectMovie
{
    public abstract class Movie
    {
        //properties
        public abstract string Title { get; set; }
        public string Director { get; set; } = "unknown";
        public string Date { get; set; } = "unknown";
        //constuctor
        public Movie(string title )
        {
            Title = title;
           // Director = director;
        }
        //methods


    }
}
