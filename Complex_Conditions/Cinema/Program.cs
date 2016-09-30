using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var tipe = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var s = 0.0;

            if (tipe == "Premiere")
            {
                s = r * c * 12.00;
            }
            else if (tipe == "Normal")
            {
                s = r * c * 7.50;
            }
            else if (tipe == "Discount")
            {
                s = r * c * 5.00;
            }
            Console.WriteLine("{0:f2}", s);
            Console.WriteLine("leva");
        }
    }
}
