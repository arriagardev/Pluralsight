using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
    [TestClass]
    public class ReferenceTypeTests
    {

        [TestMethod]
        public void ArrayTest()
        {
            float[] array;
            array = new float[3];
            SetNumber(array,1);

            Assert.AreEqual(5, array[1]);
        }

        private void SetNumber(float[] array, int index)
        {
            array[index] = 5;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A Gradebook", book1.Name);
        }

        private void GiveBookAName(Gradebook book)
        {
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Tobe";
            string name2 = "tobe";

            bool result = String.Equals(name1, name2, StringComparison.CurrentCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVarablesHoldAValue()
        {
            Int32 x = 5;
            int y = 8;
            y = x;
            Assert.AreEqual(x, y);
        }
    }    
}
