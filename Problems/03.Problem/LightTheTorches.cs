using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class LightTheTorches
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            char[] rooms = new char[len];
            char[] charactersToFill = Console.ReadLine().ToCharArray();
            int index = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = charactersToFill[index];
                index++;
                index %= charactersToFill.Length;

            }

            string input = Console.ReadLine();
            int currentIndex = rooms.Length / 2;
            while (input != "END")
            {
                
                string[] data = input.Split(' ');
                string direction = data[0];
                int offset = int.Parse(data[1]) + 1;

                if (currentIndex == 0 && direction == "LEFT")
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (currentIndex == rooms.Length - 1 && direction == "RIGHT")
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (direction == "LEFT")
                {
                    currentIndex = Math.Max(0, currentIndex - offset);
                }
                else
                {
                    currentIndex = Math.Min(rooms.Length - 1, currentIndex + offset);
                }

                if (rooms[currentIndex] == 'D')
                {
                    rooms[currentIndex] = 'L';
                }
                else
                {
                    rooms[currentIndex] = 'D';
                }
                input = Console.ReadLine();

            }
            int counter = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] == 'D')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter * 'D');         
        }
    }
}