using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora.Tests
{
    [TestClass]
    public class SubstractTest
    {
        public static IEnumerable<object[]> SubstractData
        {
            get
            {
                return new[]
                {
                    new object[] { 4, 1, 3 },
                    new object[] { -3, -2, -1 },
                    new object[] { 7, -3, 10 },
                    new object[] { -12, 8, -20 },
                    new object[] { 0, 1, -1 },
                    new object[] { 9, 0, 9 },
                    new object[] { -9, 0, -9 },
                    new object[] { 0, -6, 6 },
                    new object[] { 0, 0, 0 },
                };
            }
        }
        
        [TestMethod]
        [DynamicData(nameof(SubstractData))]
        public void VerifySubstractOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedSubstract)
        {
            var resultOfSubstract = new Substract(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }
    }
}
