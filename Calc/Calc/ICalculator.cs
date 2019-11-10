namespace Calc
{
    public enum Operations
    {
        Addition = 1 ,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
    }

    public interface ICalculator
    {
        void AddOperand(int value);
        void AddOperation(Operations operation);
        void setTempVar1(int inTempvar1);
    }

    public class Calculator : ICalculator
    {

       private int TempVar1;
       private int TempVar2;
       private int sumary;

        public void setTempVar1(int inTempVar1)
        {   
           
        }
        public void AddOperand(int value)
        {
          
        }        

        public void AddOperation(Operations operation)
        {          

        }

        public string Calculate(Operations operations)
        {
            int i = (int)operations;
            switch(i)
            {
                case 1:
                    sumary = TempVar1 + TempVar2;
                    return sumary.ToString();
                case 2:
                    sumary = TempVar1 - TempVar2;
                    return sumary.ToString();
                case 3:
                    sumary = TempVar1 * TempVar2;
                    return sumary.ToString();
                case 4:
                    sumary = TempVar1 / TempVar2;
                    return sumary.ToString();
                default:
                    return null;
            }

        }

    }
}
