using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class AverageGrades
    {
        static void Main()
        {
            int repeats = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> result = new SortedDictionary<string, double>();

            for (int i = 0; i < repeats; i++)
            {
                string[] nameAndGrades = Console.ReadLine().Split(' ').ToArray();
                string name = nameAndGrades[0];
                List<double> grades = new List<double>();

                for (int iGrades = 1; iGrades < nameAndGrades.Length; iGrades++)
                {
                    grades.Add(double.Parse(nameAndGrades[iGrades]));
                }
                double averageGrade = grades.Average();

                if (averageGrade >= 5.00)
                {
                    result.Add(name, averageGrade);
                }
            }

            foreach (KeyValuePair<string, double> element in result)
            {
                Console.WriteLine("{0} -> {1:f2}", element.Key.OrderBy(w => w), element.Value);
            }
        }
        static Student ReadStudent()
        {

            List<double> result = new List<double>();

            for (int i = 0; i < repeats; i++)
            {
                string[] nameAndGrades = Console.ReadLine().Split(' ').ToArray();
                string name = nameAndGrades[0];
                List<double> grades = new List<double>();

                for (int iGrades = 1; iGrades < nameAndGrades.Length; iGrades++)
                {
                    grades.Add(double.Parse(nameAndGrades[iGrades]));
                }
                double averageGrade = grades.Average();

                if (averageGrade >= 5.00)
                {
                    result.Add(name, averageGrade);
                }
            }
            return result;
        }
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade
            {
                get
                {
                    Grades.Average();
                }
            }
        }
    }
    
}
