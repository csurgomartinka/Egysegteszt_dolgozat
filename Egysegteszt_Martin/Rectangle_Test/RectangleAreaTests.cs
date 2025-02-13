using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Egysegteszt_Martin;

namespace Rectangle_Test
{
    [TestClass]
    public class RectangleAreaTests
    {
        [TestMethod]
        public void Pos_Return50()
        {
            double a = 5;
            double b = 10;
            double excepted = 50;
            var rec = new Rectangle();

            double result = rec.CalCulateArea(a, b);

            Assert.AreEqual(result,excepted);
        }
        [TestMethod]
        public void Width0_Return0()
        {
            double a = 0;
            double b = 10;
            double excepted = 0;
            var rec = new Rectangle();

            double result = rec.CalCulateArea(a, b);

            Assert.AreEqual(result, excepted);
        }
        [TestMethod]
        public void Height0_Return0()
        {
            double a = 10;
            double b = 0;
            double excepted = 0;
            var rec = new Rectangle();

            double result = rec.CalCulateArea(a, b);

            Assert.AreEqual(result, excepted);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegWidth_ReturnException()
        {
            double a = -5;
            double b = 10;
            var rec = new Rectangle();

            double result = rec.CalCulateArea(a, b);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegHeight_ReturnException()
        {
            double a = 10;
            double b = -5;
            var rec = new Rectangle();

            double result = rec.CalCulateArea(a, b);
        }
        [TestMethod]
        public void BigNumbers_Return2000000000000()
        {
            double a = 1000000;
            double b = 2000000;
            double excepted = 2000000000000;
            var rec = new Rectangle();

            double result = rec.CalCulateArea(a, b);

            Assert.AreEqual(result, excepted);
        }
        [TestMethod]
        public void Numbers_Return36_9()
        {
            double a = 4.5;
            double b = 8.2;
            double excepted = 36.9;
            var rec = new Rectangle();

            double result = rec.CalCulateArea(a, b);

            Assert.AreEqual(result, excepted);
        }
    }
}
