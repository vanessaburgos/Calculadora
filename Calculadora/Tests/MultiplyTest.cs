using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora.Tests
{
    [TestClass]
    public class MultiplyTest
    {
        public static IEnumerable<object[]> MultiplyData
        {
            get
            {
                return new[]
                {
                    new object[] { 8, 1, 8 },
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
        [DynamicData(nameof(MultiplyData))]
        public void VerifyMultiplyOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedMultiply)
        {
            var resultOfMultiply = new Multiply(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedMultiply, resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
        }
    } 
}
    