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
            calculator.AddOperand(Operands.Two);
            calculator.AddOperation(Operations.Addition);
            calculator.AddOperand(Operands.Two);

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
            calculator.AddOperand(Operands.Four);
            calculator.AddOperation(Operations.Subtraction);
            calculator.AddOperand(Operands.Two);

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
            calculator.AddOperand(Operands.Four);
            calculator.AddOperation(Operations.Multiplication);
            calculator.AddOperand(Operands.Two);

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
            calculator.AddOperand(Operands.Four);
            calculator.AddOperation(Operations.Division);
            calculator.AddOperand(Operands.Two);

            // Act
            var result = calculator.getSummary();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
