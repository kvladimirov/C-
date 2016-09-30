using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());

            var placeFromRow = Math.Truncate(((n * 100) - 100) / 70);
            var row = Math.Truncate((w * 100) / 120);
            var place = (placeFromRow * row) - 3;

            Console.WriteLine(place);
        }
    }
}
