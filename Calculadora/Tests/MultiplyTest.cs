using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora.Tests
{
    [TestClass]
    internal class MultiplyTest
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] { 2, 1, 2 },
                    new object[] { -3, -2, 6 },
                    new object[] { 7, -3, -21 },
                    new object[] { -12, 8, -96 },
                    new object[] { 0, 1, 0 },
                    new object[] { 9, 0, 0 },
                    new object[] { -9, 0, 0 },
                    new object[] { 0, -6, 0 },
                    new object[] { 0, 0, 0 },
                };
            }
        }

        [TestMethod]

        [DynamicData(nameof(AdditionData))]
        public void VerifyMultiplytOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedMultiply)
        {
            var resultOfMultiply = new Multiply(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedMultiply, resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
        }
    }
}
    