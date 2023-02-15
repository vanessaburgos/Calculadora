using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora.Tests
{
    [TestClass]
    public class SubstractTest
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] { 2, 1, 1 },
                    new object[] { -3, -2, -5 },
                    new object[] { 7, -3, -4 },
                    new object[] { -12, 8, 15 },
                    new object[] { 0, 1, -1 },
                    new object[] { 9, 0, 9 },
                    new object[] { -9, 0, -9 },
                    new object[] { 0, -6, -6 },
                    new object[] { 0, 0, 0 },
                };
            }
        }
        
        [TestMethod]

        [DynamicData(nameof(AdditionData))]
        public void VerifySubstractOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedSubstract)
        {
            var resultOfSubstract = new Sum(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }
    }
}
