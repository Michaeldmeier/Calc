
public enum Operations
{
    Addition = 1,
    Subtraction = 2,
    Multiplication = 3,
    Division = 4,
}

public enum Operands
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9
}

public interface ICalculator
{
    void AddOperand(Operands operands);
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


    public void AddOperand(Operands operands)
    {
        addedNumberOne = addedNumberOne * 10 + operands;
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

        switch (inOperator)
        {
            case Operations.Addition:
                summary = numberOne + numberTwo;
                break;
            case Operations.Subtraction:
                summary = numberOne - numberTwo;
                break;
            case Operations.Multiplication:
                summary = numberOne * numberTwo;
                break;
            case Operations.Division:
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

