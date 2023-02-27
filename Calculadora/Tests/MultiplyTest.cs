using Calculadora.Utils;
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
                return OperationHelper.GetMultiplyAdditionalData();
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
    