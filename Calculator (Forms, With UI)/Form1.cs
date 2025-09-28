using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator__Forms__With_UI_
{
    public partial class CalculatorApp : Form
    {
        public int iCurrentValue = 0;
        public int iTotal = 0;
        public bool newEntry = true;
        public bool bAddition = false;
        public bool bSubtraction = false;
        public bool bMultiplication = false;
        public bool bDivision = false;
        string szText;
        int iDigit;
        int iNumber;
        int iwholeNumber;

        //on the first variable, which is double, it is a placeholder for the result 
        //and ongoing calculations

        

        // Adding event handlers for arithmetic buttons

        /*
    Addition.Click += ArithmeticButton_Click;
    Subtraction.Click += ArithmeticButton_Click;
    Multiplication.Click += ArithmeticButton_Click;
    Divison.Click += ArithmeticButton_Click;
        */

        public CalculatorApp()
        {
            InitializeComponent();
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            ValueTextBox.Text += "-";
            szText += "-";
            iNumber = iDigit;
            iDigit = 0;
            bAddition = false;
            bDivision = false;
            bMultiplication = false;
            bSubtraction = true;
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            ValueTextBox.Text += "+";
            szText += "+";
            iNumber = iDigit;
            iDigit = 0;
            bAddition = true;
            bDivision = false;
            bMultiplication = false;
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            ValueTextBox.Text += "/";
            szText += "/";
            iNumber = iDigit;
            iDigit = 0;
            bAddition = false;
            bDivision = true;
            bMultiplication = false;
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();

        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            ValueTextBox.Text += "x";
            szText += "x";
            iNumber = iDigit;
            iDigit = 0;
            bAddition = false;
            bDivision = false;
            bMultiplication = true;
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            szText += e.KeyChar;
            szText.Trim();
            if (char.IsDigit(e.KeyChar))
            {
                if (iDigit > 0)
                {
                    iDigit = (e.KeyChar - '0')  +(iDigit * 10);
                }
                else
                {
                    iDigit = e.KeyChar - '0';


                }
            }
            else if (e.KeyChar == '+')
            {
                iNumber = iDigit;
                iDigit = 0;
                bAddition = true;
                bDivision = false;
                bMultiplication = false;
                bSubtraction = false; 
            }
            else if (e.KeyChar == '-')
            {
                iNumber = iDigit;
                iDigit = 0;
                bAddition = false;
                bDivision = false;
                bMultiplication = false;
                bSubtraction = true;
            }
            else if (e.KeyChar == 'x')
            {
                iNumber = iDigit;
                bMultiplication = true;
                bAddition = false;
                bDivision = false;
                bSubtraction = false;
                iDigit = 0;
            }
            else if (e.KeyChar == '/')
            {
                iNumber = iDigit;
                bDivision = true;
                bMultiplication = false;
                bAddition = false;
                bSubtraction = false;
                iDigit = 0;
            }
            if (e.KeyChar == '=')
            {
                int iResul = 0;
                if (bAddition)
                {
                    iNumber += iDigit;
                }
                else if (bMultiplication)
                {
                    iNumber *= iDigit;
                }
                else if (bDivision)
                {
                    if(iDigit == 0)
                    {
                        MessageBox.Show("Cannot devide by 0");
                        return;

                    }
                    iNumber /= iDigit;
                }
                else if(bSubtraction)
                {
                    iNumber -= iDigit;

                }
                iwholeNumber = iNumber;
                iNumber = 0;
                iDigit = iwholeNumber;
                szText += iwholeNumber.ToString(); ;
                ValueTextBox.Text = szText;
                e.Handled = true;
                ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
                ValueTextBox.SelectionLength = 0;
                ValueTextBox.Focus();

            }
            //    if (char.IsDigit(e.KeyChar))
            //{
            //    iDigit = 
            //    //e.Handled = true;
            //    if (bAddition)
            //    {
            //        iTotal += e.KeyChar;

            //    }

            //}
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            szText = "";
            ValueTextBox.Text = "";
            iNumber = 0;
            iDigit = 0;


        }

        private void EqualOperator_Click(object sender, EventArgs e)
        {

            ValueTextBox.Text += "=";
            szText += "=";
            int iResul = 0;
            if (bAddition)
            {
                iNumber += iDigit;
            }
            else if (bMultiplication)
            {
                iNumber *= iDigit;
            }
            else if (bSubtraction)
            {
                iNumber -= iDigit;
            }
            else if (bDivision)
            {
                if (iDigit == 0)
                {
                    MessageBox.Show("Cannot devide by 0");
                    return;

                }
                iNumber /= iDigit;
            }
            iwholeNumber = iNumber;
            iNumber = 0;
            iDigit = iwholeNumber;
            szText += iwholeNumber.ToString(); ;
            ValueTextBox.Text = szText;
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
        }
    }
}
