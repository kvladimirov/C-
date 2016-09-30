using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CensorYourEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] eMail = Console.ReadLine().Split('@').ToArray();
            string censored = new string('*', eMail[0].Length) + '@' + eMail[1];
            string message = Console.ReadLine();
            Console.WriteLine(message.Replace((eMail[0] + '@' + eMail[1]), censored));
        }
    }
}
