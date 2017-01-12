using System.IO;

namespace Grades
{
    internal interface IGradeTracker
    {
        void AddGrade(float grade);
        Gradestatistics ComputeStatistics();
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
        event NameChangeDelegate NameChanged;
    }
}