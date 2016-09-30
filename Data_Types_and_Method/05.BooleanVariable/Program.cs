using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            switch(Convert.ToBoolean(text))
            {
                case true :
                    Console.WriteLine("Yes");
                    break;
                case false :
                    Console.WriteLine("No");
                    break;

            }
        }
    }
}
