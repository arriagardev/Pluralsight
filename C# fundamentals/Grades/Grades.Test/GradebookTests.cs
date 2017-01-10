using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
    [TestClass]
    public class GradebookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(78);
            book.AddGrade(95);
            book.AddGrade(85);

            Gradestatistics stats = book.ComputeStatistics();

            Assert.AreEqual(95, stats.maxgrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(78);
            book.AddGrade(95);
            book.AddGrade(85);

            Gradestatistics stats = book.ComputeStatistics();

            Assert.AreEqual(78, stats.mingrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(78);
            book.AddGrade(95);
            book.AddGrade(85);

            Gradestatistics stats = book.ComputeStatistics();

            Assert.AreEqual(86, stats.avggrade);
        }
    }
}
