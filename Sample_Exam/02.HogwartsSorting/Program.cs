using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HogwartsSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            var gryffindor = 0;
            var slytherin = 0;
            var ravenclaw = 0;
            var hufflepuff = 0;
            
            //List<string> numbers = new List<string>();
            

            for (int i = 0; i < n; i++)
            {
                string[] name = Console.ReadLine().Split(' ');
                string ch = name[0] + name[1];
                var sum = 0;
                string firstInit = name[0];
                string secondInit = name[1];

                for (var k = 0; k < ch.Length; k++)
                {

                    sum += ch[k];
                }
                string number = string.Format($"{sum}{firstInit[0]}{secondInit[0]}");
                if (sum % 4 == 0)
                {
                    gryffindor++;
                    Console.WriteLine($"Gryffindor {number}");
                    //string init = "Gryffindor " + sum + "" + firstInit[0] + secondInit[0];
                   // numbers.Add(init);
                }
                if (sum % 4 == 1)
                {
                    slytherin++;
                    Console.WriteLine($"Slytherin {number}");
                    //string init = "Slytherin " + sum + "" + firstInit[0] + secondInit[0];
                    // numbers.Add(init);
                }
                if (sum % 4 == 2)
                {
                    ravenclaw++;
                    Console.WriteLine($"Ravenclaw {number}");
                    //string init = "Ravenclaw " + sum + "" + firstInit[0] + secondInit[0];
                    // numbers.Add(init);
                }
                if (sum % 4 == 3)
                {
                    hufflepuff++;
                    Console.WriteLine($"Hufflepuff {number}");
                    //string init = "Hufflepuff " + sum + "" + firstInit[0] + secondInit[0];
                    // numbers.Add(init);
                }
            }

            //foreach (var number in numbers)
            //{
                
                //Console.WriteLine(number);
            //}

            Console.WriteLine();
            Console.WriteLine($"Gryffindor: {gryffindor}\nSlytherin: {slytherin}\nRavenclaw: {ravenclaw}\nHufflepuff: {hufflepuff}");      
        }
    }
}
