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

        public string LetterGrade
        {
            get
            {
                string result;
                if (avggrade >= 90)
                {
                    result = "A";
                }
                else if (avggrade >= 80)
                {
                    result = "B";
                }
                else if (avggrade >= 70)
                {
                    result = "C";
                }
                else if (avggrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public string GradeDescription
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failing";
                        break;
                }
                return result;
            }
        }
    }
}