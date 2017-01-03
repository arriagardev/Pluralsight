using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Gradebook
    {
        public Gradebook()
        {
            grades = new List<float>();
        }

        public Gradestatistics ComputeStatistics()
        {

            return new Gradestatistics(grades);
        }

        public List<float> grades;
    }
}
