using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora.Tests
{
    [TestClass]
    public class SumTest
    {
        public static IEnumerable<object[]> SumData
        {
            get 
            {
                return new[]
                {
                    new object[] {1, 2, 3 },
                    new object[] {-2, -3, -5 },
                    new object[] {-7, -3, -10 },
                    new object[] { 12, -8, 4},
                    new object[] { 0, 1, 1},
                    new object[] { 9, 0, 9},
                    new object[] {-9, 0, -9},
                    new object[] { 0, -6, -6},
                    new object[] { 0, 0, 0},
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(SumData))]
        public void VerifySumOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedSum)
        {
            var resultOfSum = new Sum(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
        }
    }
}
