using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] sep = Console.ReadLine().Split();

            string input = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries).ToString();
            Dictionary<string, int> teams = new Dictionary<string, int>();
            Dictionary<string, int> sortTeams = new Dictionary<string, int>();
            

            while (input != "final")
            {
                List<string> data = input.Split(new char[] { ' ', '#', '?', '!', '>', '<', '/', '\\', '%', '$', '&' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> listTeam = new List<string>();
                int[] result = new int[2];
                for (int i = 0; i < data.Count; i++)
                {
                    string team = ReverseString(data[i]).ToLower();                  
                    result[0] = input[input.Length - 1];
                    result[1] = input[input.Length - 3];
                    if (team.Length > 3)
                    {
                        listTeam.Add(team);
                    }
                }
                for (int j = 0; j < listTeam.Count; j++)
                {
                    if (j == 0)
                    {
                        if (teams.ContainsKey(listTeam[0]))
                        {

                            teams[listTeam[0]] += result[1];
                        }
                        if(!teams.ContainsKey(listTeam[1]))
                        {
                            teams[listTeam[0]] = result[1];
                        }

                    }
                    if (j == 1)
                    {
                        if (teams.ContainsKey(listTeam[1]))
                        {

                            teams[listTeam[1]] += result[0];
                        }
                        if(!teams.ContainsKey(listTeam[1]))
                        {
                            teams[listTeam[1]] = result[0];
                        }

                    }

                }
                for (int j = 0; j < listTeam.Count; j++)
                {
                    if (sortTeams.ContainsKey(listTeam[j]))
                    {
                        if (result[1] > result[0] && j == 0)
                        {
                            sortTeams[listTeam[j]] += 3;
                            break;
                        }
                        if (result[1] < result[0] && j == 1)
                        {
                            sortTeams[listTeam[j]] += 3;
                            break;
                        }
                        if (result[0] == result[1])
                        {
                            sortTeams[listTeam[j]]++;
                            
                            break;
                        }

                    }
                    if(!sortTeams.ContainsKey(listTeam[j]))
                    {
                        if (result[1] > result[0] && j == 0)
                        {
                            sortTeams[listTeam[j]] = 3;
                            break;
                        }
                        if (result[1] < result[0] && j == 1)
                        {
                            sortTeams[listTeam[j]] = 3;
                            break;
                        }
                        if (result[0] == result[1])
                        {
                            sortTeams[listTeam[j]] = 1;
                            
                            break;
                        }
                        
                    }
                }

                
                input = Console.ReadLine();
            }
            //Dictionary<string, int> a = new Dictionary<string, int>();

            //foreach (var item in teams.OrderBy(t => -t.Value))
            //{

            //    a.Add(item.Key, item.Value);  
            //}
            foreach (var item in sortTeams.OrderBy(t => -t.Value))
            {
                int n = 1;
                Console.Write($"{n}. {item.Key.ToUpper()} {item.Value}");
                n++;
            }     
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
