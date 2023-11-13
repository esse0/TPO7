using System;


namespace CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void PositiveIntegerSumTest()
        {
            Assert.AreEqual(Calculator.GetSum(5, 5), 10);
        }

        [TestMethod]
        public void NegativeIntegerSumTest()
        {
            Assert.AreEqual(Calculator.GetSum(-5, -5), -10);
        }

        [TestMethod]
        public void PositiveFloatSumTest()
        {
            Assert.AreEqual(Calculator.GetSum(5.5f, 5f), 10.5);
        }

        [TestMethod]
        public void NegativeFloatSumTest()
        {
            Assert.AreEqual(Calculator.GetSum(-5.5f, -5f), -10.5);
        }

        [TestMethod]
        public void PositiveIntegerSubtractTest()
        {
            Assert.AreEqual(Calculator.GetSubtract(0, 100), -100);
        }

        [TestMethod]
        public void NegativeIntegerSubtractTest()
        {
            Assert.AreEqual(Calculator.GetSubtract(0, -100), 100);
        }

        [TestMethod]
        public void PositiveFloatSubtractTest()
        {
            Assert.AreEqual(Calculator.GetSubtract(10f, 5.73f), 4.27f);
        }

        [TestMethod]
        public void NegativeFloatSubtractTest()
        {
            Assert.AreEqual(Calculator.GetSubtract(-10f, -5.73f), -4.27f);
        }

        [TestMethod]
        public void PositiveIntegerMultiplyTest()
        {
            Assert.AreEqual(Calculator.GetMultiply(0, 100), 0);
        }

        [TestMethod]
        public void NegativeIntegerMultiplyTest()
        {
            Assert.AreEqual(Calculator.GetMultiply(-10, -100), 1000);
        }

        [TestMethod]
        public void PositiveFloatMultiplyTest()
        {
            Assert.AreEqual(Calculator.GetMultiply(0.5f, 54.40f), 27.20f);
        }

        [TestMethod]
        public void NegativeFloatMultiplyTest()
        {
            Assert.AreEqual(Calculator.GetMultiply(-0.5f, -100.50f), 50.25f);
        }

        [TestMethod]
        public void PositiveIntegerDivideTest()
        {
            Assert.AreEqual(Calculator.GetDivide(10, 2), 5);
        }

        [TestMethod]
        public void NegativeIntegerDivideTest()
        {
            Assert.AreEqual(Calculator.GetDivide(-100, -10), 10);
        }

        [TestMethod]
        public void PositiveDivideFloatTest()
        {
            Assert.AreEqual(Calculator.GetDivide(10.5f, 5.25f), 2);
        }

        [TestMethod]
        public void NegativeDivideFloatTest()
        {
            Assert.AreEqual(Calculator.GetDivide(-14.5f, -2.5f), 5.8f);
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => { Calculator.GetDivide(10, 0); });
        }
    }
}