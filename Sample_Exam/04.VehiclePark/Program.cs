using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VehiclePark
{
    class Program
    {
        static void Main()
        {
            List<string> cars = Console.ReadLine().Split(' ').ToList();
            string input = Console.ReadLine();
            int sale = 0;

            while (input != "End of customers!")
            {
                string[] data = input.Split(' ');
                string carWanted = data[0].ToLower()[0] + data[2];
                int index = -1;
                for (int i = 0; i < cars.Count; i++)
                {
                    if (carWanted == cars[i])
                    {
                        index = i;
                        break;
                    }

                }
                if (index == - 1)
                {
                    Console.WriteLine("No");

                }

                else
                {
                    int Price = carWanted[0] * int.Parse(carWanted.Substring(1, carWanted.Length - 1));
                    cars.Remove(cars[index]);
                    Console.WriteLine($"Yes, sold for {Price}$");
                    sale++;

                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Vehicles left: {0}", string.Join(", ", cars));
            Console.WriteLine($"Vehicles sold: {sale}");
        }
    }
}
