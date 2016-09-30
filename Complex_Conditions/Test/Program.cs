using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var hTest = int.Parse(Console.ReadLine());
            var mTest = int.Parse(Console.ReadLine());
            var hArrival = int.Parse(Console.ReadLine());
            var mArrival = int.Parse(Console.ReadLine());

            if ( hArrival == hTest && mArrival > mTest || hArrival > hTest)
            {
                Console.WriteLine("Late");
                {
                    if (hArrival == hTest)
                    {
                        Console.WriteLine("{0} minutes after the start", mArrival - mTest);
                    }
                    else if (hArrival > hTest && hArrival - hTest > 1 && mTest <= mArrival)
                    {
                        Console.WriteLine("{0}:{1:00} hours after the start", hArrival - hTest, mArrival - mTest);
                    }
                    else if (hArrival > hTest && (hArrival - hTest) > 1 && mTest > mArrival)
                    {
                        Console.WriteLine("{0}:{1:00} hours after the start", hArrival - hTest - 1, 60 + mArrival - mTest);
                    }
                    else if (hArrival > hTest && (hArrival - hTest) == 1 && mTest > mArrival)
                    {
                        Console.WriteLine("{0} minutes after the start", 60 + mArrival - mTest);
                    }
                    else if (hArrival > hTest && (hArrival - hTest) == 1 && mTest <= mArrival)
                    {
                        Console.WriteLine("{0}:{1:00} hours after the start", hArrival - hTest, mArrival - mTest);
                    }
                }
            }
            else if (hArrival == hTest && mArrival == mTest || Math.Abs(((hArrival * 60) + mArrival) - ((hTest * 60) + mTest)) <= 30)
            {
                Console.WriteLine("On time");
                if (hArrival == hTest)
                {
                    Console.WriteLine("{0} minutes before the start ", 60 + mArrival - mTest);
                }
                else if (hArrival < hTest)
                {
                    Console.WriteLine("{0} minutes before the start", 60 + mTest - mArrival);
                }
            }
            else if (Math.Abs(((hArrival * 60) + mArrival) - ((hTest * 60) + mTest)) > 30)
            {
                Console.WriteLine("Early");
                if (hArrival == hTest)
                {
                    Console.WriteLine("{0} minutes before the start", mTest - mArrival);
                }
                else if (hTest > hArrival && (hTest - hArrival) > 1 && mTest >= mArrival)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", hTest - hArrival, mTest - mArrival);
                }
                else if (hArrival < hTest && (hTest - hArrival) > 1 && mTest < mArrival)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", hTest - hArrival - 1, 60 + mTest - mArrival);
                }
                else if (hArrival < hTest && (hTest - hArrival) == 1  && mTest < mArrival)
                {
                    Console.WriteLine("{0} minutes before the start", 60 + mTest - mArrival);
                }
                else if (hArrival < hTest && (hTest - hArrival) == 1 && mTest >= mArrival)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", hTest - hArrival, mTest - mArrival);
                }
            }
        }
    }
}
