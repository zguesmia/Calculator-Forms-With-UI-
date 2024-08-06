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
            
        }

        private void Addition_Click(object sender, EventArgs e)
        {

        }

        private void Division_Click(object sender, EventArgs e)
        {

        }

        private void Multiplication_Click(object sender, EventArgs e)
        {

        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (bAddition)
                {
                    iTotal += e.KeyChar;

                }

            }
           
        }
    }
}
