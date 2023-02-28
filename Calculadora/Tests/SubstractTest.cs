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
        public void VerifySubstractOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedSubstract)
        {
            var resultOfSubstract = new Substract(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedSubstract), resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }
    }
}
