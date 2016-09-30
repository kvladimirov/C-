using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var something = Console.ReadLine();

            if (something == "banana" || something == "apple" || something == "kiwi" || something == "cherry" || something == "lemon" || something == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if(something == "tomato" || something == "cucumber" || something == "pepper" || something == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
 