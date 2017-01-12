using System;
using System.IO;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();            
            synth.Speak("Hello, this is the GradeBook Program");

            IGradeTracker book = new ThrowAwayGradebook();
            //GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);
        }

        private static void WriteResults(IGradeTracker book)
        {
            Gradestatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);

            book.WriteGrades(Console.Out);

            WriteValue("Highest", stats.maxgrade);
            WriteValue("Lowest", stats.mingrade);
            WriteValue("Average", stats.avggrade);
            WriteValue(stats.GradeDescription, stats.LetterGrade);
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputfile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputfile);
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(90);
            book.AddGrade(78.5f);
            book.AddGrade(85);
            book.AddGrade(99);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                book.NameChanged += new NameChangeDelegate(OnNameChanged);
                book.NameChanged += new NameChangeDelegate(OnNameChanged2);

                Console.WriteLine("Type a name for the new Grade Book: ");
                book.Name = Console.ReadLine();

                //book.Name = "Tobe's Grade Book";
                //book.Name = "Grade Book";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void OnNameChanged(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine($"Grade Book changing from {args.ExistingName} to {args.NewName}");
        }

        static void OnNameChanged2(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine("***");
        }

        static void WriteValue (string message, float value)
        {
            Console.WriteLine($"{message}: {value}");
        }
        static void WriteValue(string message, string value)
        {
            Console.WriteLine($"{message}: {value}");
        }
    }
}
