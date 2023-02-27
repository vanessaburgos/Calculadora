using Calculadora.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Calculadora.Tests
{
    [TestClass]
    public class SumTest
    {
        public static IEnumerable<object[]> SumData
        {
            get
            {
                return OperationHelper.GetSumAdditionalData();
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
