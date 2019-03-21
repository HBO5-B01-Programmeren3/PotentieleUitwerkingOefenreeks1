using System;
using PotentieleUitwerkingOefenreeks1.Extensions;

namespace PotentieleUitwerkingOefenreeks1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingaveString = "Joachim Francois";

            Console.WriteLine(ingaveString.Omdraaier());

            Console.WriteLine(ingaveString.Omdraaier().LaatsteLetter());

            Console.WriteLine(8.Machtsverheffing(2));
            var getal = 10;
            Console.WriteLine(getal.Machtsverheffing(4));

            var points = new Points();

            
            Console.WriteLine(points.SumOfMaxPoints());


            Console.ReadKey();
        }
    }
}
