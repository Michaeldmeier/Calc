using System;
using System.Collections.Generic;
using System.Text;

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
    string changeSign();
    string addComma();
    string divideBy100();
}

public class Calculator : ICalculator
{

    private Operations calct;
    private string addedNumberOne = null;
    private string addedNumberTwo = null;
    private double summary;


    public void AddOperand(Operands operands)
    {
        addedNumberOne += (int)operands;
    }

    public void AddOperation(Operations operation)
    {
        calct = operation;
        if (addedNumberTwo == null)
        {
            addedNumberTwo = addedNumberOne;
            calct = operation;
            addedNumberOne = null;
        }
        else if (addedNumberOne != null)
        {
            addedNumberTwo = getSummary();
            calct = operation;
        }
    }

    public string addComma()
    {
        string comma;

        if (addedNumberOne != null && !addedNumberOne.Contains("."))
        {
            addedNumberOne += ".";
            comma = ".";
        }
        else if (addedNumberOne == null)
        {
            addedNumberOne = "0.";
            comma = "0.";
        }
        else
        {
            comma = "";
        }

        return comma;

    }

    public void resetValues()
    {
        addedNumberOne = null;
        addedNumberTwo = null;
    }

    private void calculate(string numberOne, string numberTwo, Operations inOperator)
    {
        double value1 = 0;
        double value2 = 0;
        int i = (int)inOperator;

       
        if (addedNumberTwo != null)
        {
            value1 = double.Parse(numberOne, System.Globalization.CultureInfo.InvariantCulture);
        }



        if (addedNumberOne != null)
        {
            value2 = double.Parse(numberTwo, System.Globalization.CultureInfo.InvariantCulture);
        }

        switch (inOperator)
        {
            case Operations.Addition:
                summary = value1 + value2;
                break;
            case Operations.Subtraction:
                summary = value1 - value2;
                break;
            case Operations.Multiplication:
                summary = value1 * value2;
                break;
            case Operations.Division:
                if (value2 == 0)
                {
                    break;
                }
                else
                {
                    summary = value1 / value2;
                }
                break;
            default:
                break;
        }
    }

    public string getSummary()
    {
        calculate(addedNumberTwo, addedNumberOne, calct);
        addedNumberTwo = summary.ToString();
        addedNumberOne = null;

        return summary.ToString();
    }

    public String changeSign()
    {
        if (addedNumberOne != null)
        {
            summary = double.Parse(addedNumberOne, System.Globalization.CultureInfo.InvariantCulture) * (-1);
            addedNumberOne = summary.ToString();
        }
        else
        {
            summary = double.Parse(addedNumberTwo, System.Globalization.CultureInfo.InvariantCulture) * (-1);
            addedNumberTwo = summary.ToString();
        }
        return summary.ToString();
    }

    public String divideBy100()
    {
        if (addedNumberOne != null)
        {

            summary = double.Parse(addedNumberOne, System.Globalization.CultureInfo.InvariantCulture) / 100;
            addedNumberOne = summary.ToString();
        }
        else if (addedNumberOne == null && addedNumberTwo != null)
        {
            summary = double.Parse(addedNumberTwo, System.Globalization.CultureInfo.InvariantCulture) / 100;
            addedNumberTwo = summary.ToString();

        }
        else
        {
            summary = 0;
        }

        return summary.ToString();
    }

}




