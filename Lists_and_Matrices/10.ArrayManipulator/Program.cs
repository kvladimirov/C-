using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            
            while (input != "print")
            {
                string[] data = input.Split(' ');

                switch (data[0])
                {
                    case "add":
                        nums.Insert(int.Parse(data[1]), int.Parse(data[2]));
                        break;
                    case "addMany":
                        List<int> numbers = new List<int>();
                        for (int i = 2; i < data.Length; i++)
                        {
                            numbers.Add(int.Parse(data[i]));
                        }
                        nums.InsertRange(int.Parse(data[1]), numbers);
                        break;
                    case "contains":
                        if (nums.Contains(int.Parse(data[1])))
                        {
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] == int.Parse(data[1]))
                                {
                                    Console.WriteLine(i);
                                    break;
                                }

                            }
                        }

                        else
                        {
                            Console.WriteLine(-1);
                        }                        
                        break;
                    case "remove":
                        nums.RemoveAt(int.Parse(data[1]));
                        break;
                    case "shift":
                        for (int j = 0; j < int.Parse(data[1]); j++)
                        {
                            int num = nums[0];
                            for (int i = 0; i < nums.Count - 1; i++)
                            {
                                nums[i] = nums[i + 1];
                            }
                            nums[nums.Count - 1] = num;
                        }
                        break;
                    case "sumPairs":
                        for (int i = 0; i < nums.Count - 1; i++)
                        {
                            nums[i] += nums[i + 1];
                            nums.RemoveAt(i + 1);
                        }                                       
                        break;
                }
                input = Console.ReadLine();
            }
            
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}
