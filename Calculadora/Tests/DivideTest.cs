using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora.Tests
{
    [TestClass]

    public class DivideTest
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] { 2, 1, 2 },
                    new object[] { -3, -3, 1 },
                    new object[] { 7, -4, -5 },
                    new object[] { -12, 4, -3 },
                    new object[] { 0, 1, 0 },
                    new object[] { 0, -6, 0 },
                };
            }
        }

        [TestMethod]

        [DynamicData(nameof(AdditionData))]
        public void VerifyDividetOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedDivide)
        {
            var resultOfDivide = new Divide(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
        }
    }
}
