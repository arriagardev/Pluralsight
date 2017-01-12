using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Gradebook : GradeTracker
    {
        public Gradebook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override Gradestatistics ComputeStatistics()
        {

            return new Gradestatistics(grades);
        }

        protected List<float> grades;

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }
    }
}
