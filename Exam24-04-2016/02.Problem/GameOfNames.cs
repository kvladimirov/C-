using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
    class GameOfNames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            long currentScore = int.MinValue;
            string currentName = null;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                long score = long.Parse(Console.ReadLine());
                
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] % 2 == 0)
                    {
                        score += name[j];
                    }
                    else
                    {
                        score -= name[j];
                    }
                }
                if (score > currentScore)
                {
                    currentScore = score;
                    currentName = name;
                }
                if (score == currentScore)
                {
                    continue;
                }
            }

            Console.WriteLine($"The winner is {currentName} - {currentScore} points");
        }
    }
}
