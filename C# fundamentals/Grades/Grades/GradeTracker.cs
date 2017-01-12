using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract Gradestatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);

        protected string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (_name != value)
                {
                    NameChangeEventArgs args = new NameChangeEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;
                    NameChanged(_name, args);
                }
                _name = value;

            }
        }

        public event NameChangeDelegate NameChanged;
    }
}
