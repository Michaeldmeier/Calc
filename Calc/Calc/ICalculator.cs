namespace Calc
{
    public enum Operations
    {
        Addition = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
    }

    public interface ICalculator
    {
        void AddOperand(int value);
        void AddOperation(Operations inOperator);
        string getSummary();
        void resetValues();
    }

    public class Calculator : ICalculator
    {

        private Operations calct;
        private int addedNumberOne = 0;
        private int addedNumberTwo = 0;
        private int summary;


        public void AddOperand(int value)
        {
            addedNumberOne = addedNumberOne * 10 + value;
        }

        public void AddOperation(Operations operation)
        {
            calct = operation;
            if (addedNumberTwo == 0)
            {
                addedNumberTwo = addedNumberOne;
                addedNumberOne = 0;
            }
        }

        public void resetValues()
        {
            addedNumberOne = 0;
            addedNumberTwo = 0;
        }

        private void calculate(int numberOne, int numberTwo, Operations inOperator)
        {
            int i = (int)inOperator;
            switch (i)
            {
                case 1:
                    summary = numberOne + numberTwo;
                    break;
                case 2:
                    summary = numberOne - numberTwo;
                    break;
                case 3:
                    summary = numberOne * numberTwo;
                    break;
                case 4:
                    if (numberTwo == 0)
                    {
                        break;
                    }
                    else
                    {
                        summary = numberOne / numberTwo;
                    }
                    break;
                default:
                    break;
            }
        }
    
            public string getSummary()
            {
                calculate(addedNumberTwo, addedNumberOne, calct);
                addedNumberTwo = summary;
                addedNumberOne = 0;

                return summary.ToString();
            }
        
    }
}
