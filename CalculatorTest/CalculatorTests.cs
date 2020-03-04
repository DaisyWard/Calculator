using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.IO;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CheckAddOperation()
        {
            string operatingString = "+";
            double num1 = 5;
            double num2 = 8;
            double expected = 13;

            double actual = Program.CheckOperation(operatingString, num1, num2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckSubtractOperation()
        {
            string operatingString = "-";
            double num1 = 5;
            double num2 = 8;
            double expected = -3;

            double actual = Program.CheckOperation(operatingString, num1, num2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckMultiplyOperation()
        {
            string operatingString = "*";
            double num1 = 5;
            double num2 = 8;
            double expected = 40;

            double actual = Program.CheckOperation(operatingString, num1, num2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckDivideOperation()
        {
            string operatingString = "/";
            double num1 = 5;
            double num2 = 8;
            double expected = 0.625;

            double actual = Program.CheckOperation(operatingString, num1, num2);

            Assert.AreEqual(expected, actual);

        }
    }
}
