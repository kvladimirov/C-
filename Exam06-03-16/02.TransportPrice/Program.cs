using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();
            var price = 0.00;
            if (dayOrNight == "day")
            {
                if (n < 20)
                {
                    price = 0.7 + n * 0.79;
                }

                if (n >= 20)
                {
                    price = n * 0.09;
                }

                if (n >= 100)
                {
                    price = n * 0.06;
                }
            }

            if (dayOrNight == "night")
            {
                if (n < 20)
                {
                    price = 0.7 + n * 0.90;
                }

                if (n >= 20)
                {
                    price = n * 0.09;
                }

                if (n >= 100)
                {
                    price = n * 0.06;
                }
            }
            Console.WriteLine(price);
        }
    }
}
