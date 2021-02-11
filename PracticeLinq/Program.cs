using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameNames = new List<string>
            { "Red Dead Redemption", "DOOM", "Uncharted", "W.O.W.", "Myst", "GTA San Andreas", };

            foreach (string s in SortByLength(videoGameNames))
            {
                Console.WriteLine(s);
            }
        }

        private static IEnumerable<string> SortByLength(List<string> videoGameNames)
        {
            var sorted = from s in videoGameNames
                         orderby s.Length descending
                         select s;
            return sorted;
        }
    }
}
