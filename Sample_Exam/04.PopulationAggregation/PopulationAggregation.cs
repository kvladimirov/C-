using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PopulationAggregation
{
    class PopulationAggregation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> countries = new List<string>();
            Dictionary<string, int> sortCountries = new Dictionary<string, int>();
            Dictionary<string, long> sortCities = new Dictionary<string, long>();


            while (input != "stop")
            {
                string[] data = input.Split('\\');
              
                string first = ConvertStringToClearString(data[0]);
                string second = ConvertStringToClearString(data[1]);
                long population = long.Parse(data[2]);

                
                if (first[0] >= 97 && first[0] <= 122 && second[0] >= 65 && second[0] <= 90)
                {
                    if (sortCountries.ContainsKey(second))
                    {
                        sortCountries[second]++;
                    }
                    else
                    {
                        sortCountries[second] = 1;
                    }

                    if (sortCities.ContainsKey(first))
                    {
                        sortCities[first] = population;
                    }
                    else
                    {
                        sortCities[first] = population;
                    }
                    
                }

                if (first[0] >= 65 && first[0] <= 90 && second[0] >= 97 && second[0] <= 122)
                {
                    if (sortCountries.ContainsKey(first))
                    {
                        sortCountries[first]++;
                    }
                    else
                    {
                        sortCountries[first] = 1;
                    }

                    if (sortCities.ContainsKey(second))
                    {
                        sortCities[second] = population;
                    }
                    else
                    {
                        sortCities[second] = population;
                    }
                }
                input = Console.ReadLine();
            }
            
            foreach (var p in sortCountries.OrderBy(i => i.Key))
            {
                Console.WriteLine("{0} -> {1}",
                p.Key,
                p.Value);
            }
            foreach (var c in sortCities.OrderBy(i => -i.Value).Take(3))
            {
                Console.WriteLine("{0} -> {1}",
                c.Key,
                c.Value);
            }
        }
        static string ConvertStringToClearString(string name)
        {
            string a = null;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'A' && name[i] <= 'z')
                {
                    a += "" + name[i];
                }
            }
            return a;
        }
    }
}
