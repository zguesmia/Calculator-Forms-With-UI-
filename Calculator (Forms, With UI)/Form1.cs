using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public int iTotal = -1;
        public bool newEntry = true;
        public bool bAddition = false;
        public bool bSubtraction = false;
        public bool bMultiplication = false;
        public bool bDivision = false;

        //on the first variable, which is double, it is a placeholder for the result 
        //and ongoing calculations



        // Adding event handlers for arithmetic buttons

        //

        public CalculatorApp()
        {
            InitializeComponent();
            this.ActiveControl = ValueTextBox;
            Reset();
        }

        void Reset()
        {
            bAddition = false;
            bSubtraction = false;
            bMultiplication = false;
            bDivision = false;
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
        }
        private void ApplyPendingOperation()
        {
            if (iTotal == -1)
            {
                iTotal = iCurrentValue; // first number becomes the running total
                return;
            }

            if (bAddition) iTotal += iCurrentValue;
            else if (bSubtraction) iTotal -= iCurrentValue;
            else if (bMultiplication) iTotal *= iCurrentValue;
            else if (bDivision)
            {
                if (iCurrentValue == 0)
                {
                    MessageBox.Show("Cannot divide by zero!");
                    return;
                }
                iTotal /= iCurrentValue;
            }
        }

        private void ClearOps()
        {
            bAddition = bSubtraction = bMultiplication = bDivision = false;
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {

            
            ApplyPendingOperation();
            ValueTextBox.Text = iTotal.ToString() + " * ";
            ClearOps();
            bSubtraction = true;
            iCurrentValue = 0;
            


        }

        private void Addition_Click(object sender, EventArgs e)
        {
            
            ApplyPendingOperation();
            ValueTextBox.Text = iTotal.ToString() + " * ";
            ClearOps();
            bAddition = true;
            iCurrentValue = 0;
            

        }

        private void Division_Click(object sender, EventArgs e)
        {
            
         ApplyPendingOperation();
         ValueTextBox.Text = iTotal.ToString() + " * ";
         ClearOps();
         bDivision = true;
         iCurrentValue = 0;
                        
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            
            ApplyPendingOperation();
            ValueTextBox.Text = iTotal.ToString() + " * ";
            ClearOps();
            bMultiplication = true;
            iCurrentValue = 0;
            
        }






        private void ValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                int d = e.KeyChar - '0';

                //Only build the number being typed
                iCurrentValue = iCurrentValue * 10 + d;

            }

            Reset();

        }

        private void EqualOperator_Click(object sender, EventArgs e)
        {
            // If no total yet but user typed a number, seed iTotal with it.
            if (iTotal == -1 && iCurrentValue != 0)
            {
                iTotal = iCurrentValue;
            }
            else
            {
                // Finish whatever operation is pending using the number just typed.
                ApplyPendingOperation();
            }

            // Show the result (simple display – no " = " suffix so chaining stays clean)
            ValueTextBox.Text = iTotal.ToString();

            // Prepare for next calculation: keep iTotal, clear op flags, and reset current typing buffer.
            ClearOps();
            iCurrentValue = 0;

        }

        private void ValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                bAddition = false;
                bSubtraction = false;
                bMultiplication = false;
                bDivision = false;
                iTotal = -1;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ValueTextBox.Text = "";
            iCurrentValue = 0;
            iTotal = -1;
            Reset();

        }


        private void One_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 1;
            ValueTextBox.Text = ValueTextBox.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 2;
            ValueTextBox.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 3;
            ValueTextBox.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 4;
            ValueTextBox.Text = ValueTextBox.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 5;
            ValueTextBox.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 6;
            ValueTextBox.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 7;
            ValueTextBox.Text += "7";
        }
        //Make sure to upload to github! (offline mode, 8/22/2024)
        private void Eight_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 8;
            ValueTextBox.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 9;
            ValueTextBox.Text += "9";
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            int iCurrentValue = int.Parse(ValueTextBox.Text);
            iCurrentValue = (int)Math.Sqrt(iCurrentValue);
            ValueTextBox.Text = iCurrentValue.ToString();
        }

        private void SquareRoot3_Click(object sender, EventArgs e)
        {
            int iCurrentValue = int.Parse(ValueTextBox.Text);
            iCurrentValue = (int)Math.Pow(iCurrentValue, 1.0 / 3.0);
            ValueTextBox.Text = iCurrentValue.ToString();
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            
            int iCurrentValue = int.Parse(ValueTextBox.Text);
            iCurrentValue = iCurrentValue / 100;
            ValueTextBox.Text = iCurrentValue.ToString();
            
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            iCurrentValue = iCurrentValue * 10 + 0;
            ValueTextBox.Text += "0";
        }
    }
}