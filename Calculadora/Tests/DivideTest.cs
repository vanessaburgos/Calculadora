using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora.Tests
{
    [TestClass]
    public class DivideTest
    {
        public static IEnumerable<object[]> DivideData
        {
            get
            {
                return new[]
                {
                    new object[] { 22, 2, 11 },
                    new object[] { -10, -5, 2 },
                    new object[] { 30, -3, -10},
                    new object[] { -12, 6, -2 },
                    new object[] { 0, 6, 0 },
                    new object[] { 0, -8, 0 },
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(DivideData))]
        public void VerifyDivideOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedDivide)
        {
            var resultOfDivide = new Divide(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
        }
    }
}
