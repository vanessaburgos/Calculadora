using Calculadora.Utils;
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
                return OperationHelper.GetSumAdditionalData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(SumData))]
        public void VerifySumOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedSum)
        {
            var resultOfSum = new Sum(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedSum), resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
        }
    }
}
