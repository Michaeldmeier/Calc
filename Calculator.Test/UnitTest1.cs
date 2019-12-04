using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc.Test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void getSummary_AddOperand_ThenAddPlusOperator_ThenAddOperand_ReturnExpectedResult()
        {
            //Arrange
            string expectedResult = "4";

            Calculator calculator = new Calculator();
            calculator.AddOperand(2);
            calculator.AddOperation(Operations.Addition);
            calculator.AddOperand(2);

            // Act
            var result = calculator.getSummary();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void getSummary_AddOperand_ThenAddMinusOperator_ThenAddOperand_ReturnExpectedResult()
        {
            //Arrange
            string expectedResult = "2";

            Calculator calculator = new Calculator();
            calculator.AddOperand(4);
            calculator.AddOperation(Operations.Subtraction);
            calculator.AddOperand(2);

            // Act
            var result = calculator.getSummary();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void getSummary_AddOperand_ThenAddMultiplicatorOperator_ThenAddOperand_ReturnExpectedResult()
        {
            //Arrange
            string expectedResult = "8";

            Calculator calculator = new Calculator();
            calculator.AddOperand(4);
            calculator.AddOperation(Operations.Multiplication);
            calculator.AddOperand(2);

            // Act
            var result = calculator.getSummary();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void getSummary_AddOperand_ThenAddDivisionOperator_ThenAddOperand_ReturnExpectedResult()
        {
            //Arrange
            string expectedResult = "2";

            Calculator calculator = new Calculator();
            calculator.AddOperand(4);
            calculator.AddOperation(Operations.Division);
            calculator.AddOperand(2);

            // Act
            var result = calculator.getSummary();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
