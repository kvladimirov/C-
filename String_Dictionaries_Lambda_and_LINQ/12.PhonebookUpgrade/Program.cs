using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (input != "END")
            {
                string[] contact = input.Split(' ');
                switch (contact[0])
                {
                    case "A":

                        if (phonebook.ContainsKey(contact[1]))
                        {
                            phonebook[contact[1]] = contact[2];
                        }
                        else
                        {
                            phonebook[contact[1]] = contact[2];
                        }
                        break;
                    case "S":
                        if (!phonebook.ContainsKey(contact[1]))
                        {
                            Console.WriteLine($"Contact {contact[1]} does not exist.");
                        }
                        else
                        {

                            Console.WriteLine($"{contact[1]} -> {phonebook[contact[1]]}");

                        }
                        break;
                    case "ListAll":
                        foreach (var p in phonebook.OrderBy(i => i.Key))
                        {
                            Console.WriteLine("{0} -> {1}",
                            p.Key,
                            p.Value);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
