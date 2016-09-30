using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace TheFootballStatistician
{
    class Program
    {
        static void Main(string[] args)
        {

            var moneyMatch = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            decimal sum = 0;
            var arsenal = 0;
            var chelsea = 0;
            var manchesterCity = 0;
            var manchesterUnited = 0;
            var liverpool = 0;
            var everton = 0;
            var southampton = 0;
            var tottenham = 0;
            while (input != "End of the league.")
            {

                string[] data = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string team1 = data[0];
                string result = data[1];
                string team2 = data[2];
                if (result == "1")
                {
                    switch (team1)
                    {
                        case "Arsenal":
                            arsenal += 3;
                            break;
                        case "Chelsea":
                            chelsea += 3;
                            break;
                        case "ManchesterCity":
                            manchesterCity += 3;
                            break;
                        case "ManchesterUnited":
                            manchesterUnited += 3;
                            break;
                        case "Liverpool":
                            liverpool += 3;
                            break;
                        case "Everton":
                            everton += 3;
                            break;
                        case "Southampton":
                            southampton += 3;
                            break;
                        case "Tottenham":
                            tottenham += 3;
                            break;

                    }
                }
                if (result == "2")
                {
                    switch (team2)
                    {
                        case "Arsenal":
                            arsenal += 3;
                            break;
                        case "Chelsea":
                            chelsea += 3;
                            break;
                        case "ManchesterCity":
                            manchesterCity += 3;
                            break;
                        case "ManchesterUnited":
                            manchesterUnited += 3;
                            break;
                        case "Liverpool":
                            liverpool += 3;
                            break;
                        case "Everton":
                            everton += 3;
                            break;
                        case "Southampton":
                            southampton += 3;
                            break;
                        case "Tottenham":
                            tottenham += 3;
                            break;

                    }
                }
                if (result == "X")
                {
                    switch (team1)
                    {
                        case "Arsenal":
                            arsenal += 1;
                            break;
                        case "Chelsea":
                            chelsea += 1;
                            break;
                        case "ManchesterCity":
                            manchesterCity += 1;
                            break;
                        case "ManchesterUnited":
                            manchesterUnited += 1;
                            break;
                        case "Liverpool":
                            liverpool += 1;
                            break;
                        case "Everton":
                            everton += 1;
                            break;
                        case "Southampton":
                            southampton += 1;
                            break;
                        case "Tottenham":
                            tottenham += 1;
                            break;
                    }

                    switch (team2)
                    {
                        case "Arsenal":
                            arsenal += 1;
                            break;
                        case "Chelsea":
                            chelsea += 1;
                            break;
                        case "ManchesterCity":
                            manchesterCity += 1;
                            break;
                        case "ManchesterUnited":
                            manchesterUnited += 1;
                            break;
                        case "Liverpool":
                            liverpool += 1;
                            break;
                        case "Everton":
                            everton += 1;
                            break;
                        case "Southampton":
                            southampton += 1;
                            break;
                        case "Tottenham":
                            tottenham += 1;
                            break;

                    }
                }
                sum += (decimal)(moneyMatch * 1.94);
                input = Console.ReadLine();           
            }
            Console.WriteLine($"{sum:f2}lv.");
            Console.WriteLine($"Arsenal - {arsenal} points.\nChelsea - {chelsea} points.\nEverton - {everton} points.\nLiverpool - {liverpool} points.\nManchester City - {manchesterCity} points.\nManchester United - {manchesterUnited} points.\nSouthampton - {southampton} points.\nTottenham - {tottenham} points.");
        }
    }
}
