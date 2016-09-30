using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefightingOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var kids = 0;
            var adults = 0;
            var seniors = 0;

            while (input != "rain")
            {
                string data = input;
                for (var i = 0; i < data.Length; i++)
                {
                    if (i == 'K')
                    {
                        data.Remove(data[i]);
                        p--;
                        kids++;
                    }
                }
                if (p > 0)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (i == 'A')
                        {
                            data.Remove(data[i]);
                            p--;
                            adults++;
                        }
                    }
                }
                if (p > 0)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (i == 'S')
                        {
                            data.Remove(data[i]);
                            p--;
                            seniors++;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{kids}\n{adults}\n{seniors}");
        }
    }
}
