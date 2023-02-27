using Calculadora.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora.Tests
{
    [TestClass]
    public class DivideTest
    {
        public static IEnumerable<object[]> DivideData
        {
            get
            {
                return OperationHelper.GetDivideAdditionalData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(DivideData))]
        public void VerifyDivideOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedDivide)
        {
            var resultOfDivide = new Divide(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
        }
    }
}
