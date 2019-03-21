using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotentieleUitwerkingOefenreeks1.Extensions
{
    public static class Miauw
    {
        public static string Omdraaier(this string ingave)
        {
            var gesplitsteString = ingave.Split(" ");
            //Array.Reverse(gesplitsteString);
            return $"{gesplitsteString[1]} {gesplitsteString[0]}";
        }

        public static string LaatsteLetter(this string ingave)
        {
            return ingave[ingave.Length -1].ToString();
        }

        public static int Machtsverheffing(this int nummer, int exponent)
        {
            var totaal = 1;
            for (var i = 1; i <= exponent; i++)
                totaal *= nummer;
            return totaal;
        }

        public static int SumOfMaxPoints(this Points points)
        {
            return points.SeriesA.Max() + points.SeriesB.Max();
        }

    }
}
