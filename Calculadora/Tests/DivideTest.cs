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
        public void VerifyDivideOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedDivide)
        {
            var resultOfDivide = new Divide(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedDivide), resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
        }
    }
}
