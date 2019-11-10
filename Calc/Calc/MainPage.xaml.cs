using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calc
{
    public partial class MainPage : ContentPage
    {
        private ICalculator calculator = new Calculator();

        public MainPage()
        {
            InitializeComponent();
        }

     

        private void Button_ClickedC(object sender, EventArgs e)
        {
            
            Result.Text = "";
           
        }

        private void Button_ClickedPlusMinus(object sender, EventArgs e)
        {

        }

        private void Button_ClickedPercent(object sender, EventArgs e)
        {

        }

        private void Button_ClickedDivide(object sender, EventArgs e)
        {

        }

        private void Button_ClickedSeven(object sender, EventArgs e)
        {
            calculator.AddOperand(7);
            Result.Text += 7.ToString();
        }

        private void Button_ClickedEight(object sender, EventArgs e)
        {
            calculator.AddOperand(8);
            Result.Text += 8.ToString();
        }

        private void Button_ClickedNine(object sender, EventArgs e)
        {
            calculator.AddOperand(9);
            Result.Text += 9.ToString();
        }

        private void Button_ClickedMultiply(object sender, EventArgs e)
        {

        }

        private void Button_ClickedFour(object sender, EventArgs e)
        {
            calculator.AddOperand(4);
            Result.Text += 4.ToString();
        }

        private void Button_ClickedFive(object sender, EventArgs e)
        {
            calculator.AddOperand(5);
            Result.Text += 5.ToString();
        }

        private void Button_ClickedSix(object sender, EventArgs e)
        {
            calculator.AddOperand(6);
            Result.Text += 6.ToString();
        }

        private void Button_ClickedSubtract(object sender, EventArgs e)
        {

        }

        private void Button_ClickedOne(object sender, EventArgs e)
        {
            calculator.AddOperand(1);
            Result.Text += 1.ToString();
        }

        private void Button_ClickedTwo(object sender, EventArgs e)
        {
            calculator.AddOperand(2);
            Result.Text += 2.ToString();
        }

        private void Button_ClickedThree(object sender, EventArgs e)
        {
            calculator.AddOperand(3);
            Result.Text += 3.ToString();
        }

        private void Button_ClickedAddition(object sender, EventArgs e)
        {
                    

            calculator.AddOperation(Operations.Addition);
            Result.Text += " + ".ToString();
        }

        private void Button_ClickedZero(object sender, EventArgs e)
        {
            calculator.AddOperand(0);
            Result.Text += 0.ToString();
        }


        private void Button_ClickedResult(object sender, EventArgs e)
        {
            
        }

        private void Button_ClickedPoint(object sender, EventArgs e)
        {

        }
    }
}
