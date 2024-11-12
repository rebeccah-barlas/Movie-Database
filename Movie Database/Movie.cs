using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    public class Movie
    {
        public string movieTitle;
        public string movieCategory;

        public Movie (string title, string category)
        {
            movieTitle = title;
            movieCategory = category;
        }
        public void DisplayMovie()
        {
            Console.WriteLine($"Title: {movieTitle}");
        }
    }
};
