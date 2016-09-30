using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float metersPerSecond = (float)distanceInMeters / (3600 * hours + 60 * minutes + seconds);
            float kilometersPerHour = (float)(distanceInMeters/ 1000f) / (hours + (minutes / 60f) + (seconds / 3600f));
            float milesPerHour = (float)(distanceInMeters / 1609f) / (hours + (minutes / 60f) + (seconds / 3600f));
            Console.WriteLine($"{metersPerSecond}\n{kilometersPerHour}\n{milesPerHour}");
        }
    }
}
