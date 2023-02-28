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
        public void VerifyMultiplyOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedMultiply)
        {
            var resultOfMultiply = new Multiply(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedMultiply), resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
        }
    }
}
    