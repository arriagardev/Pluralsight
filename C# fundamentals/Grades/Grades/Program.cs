using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook grades = new Gradebook();
            grades.grades.Add(90);
            grades.grades.Add(78.5f);
            grades.grades.Add(85);
            grades.grades.Add(99);

            Gradestatistics stats = grades.ComputeStatistics();

            Console.WriteLine(stats.avggrade);
            Console.WriteLine(stats.mingrade);
            Console.WriteLine(stats.maxgrade);
        }
    }
}
