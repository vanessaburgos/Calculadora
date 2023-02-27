using Calculadora.Utils;
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
                return OperationHelper.GetSubstractAdditionalData();
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
