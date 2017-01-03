using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Gradestatistics
    {
        public float avggrade;
        public float mingrade;
        public float maxgrade;

        public Gradestatistics(List<float> grades)
        {
            mingrade = float.MaxValue;
            maxgrade = 0;

            float avg = 0;

            foreach (float grade in grades)
            {
                mingrade = Math.Min(mingrade, grade);
                maxgrade = Math.Max(maxgrade, grade);
                avg += grade;                
            }

            avg = avg / grades.Count;
            avggrade = avg;        
            
        }
    }
}