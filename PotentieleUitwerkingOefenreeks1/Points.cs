using System;
using System.Collections.Generic;
using System.Text;

namespace PotentieleUitwerkingOefenreeks1
{
    public class Points
    {
        public List<int> SeriesA { get; set; }
        public List<int> SeriesB { get; set; }

        public Points()
        {
            var random = new Random();
            SeriesA = new List<int>();
            SeriesB = new List<int>();
            for (var i = 0; i < 5; i++)
            {
                SeriesA.Add(random.Next(1,101));
                SeriesB.Add(random.Next(1,101));
            }
        }
    }
}
