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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
        public bool bSquareRoot = false;
        public bool bCubeRoot = false;
        string szText;
        int iDigit;
        int iNumber;
        double dNumber;
        

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
        void  ProcessAction(bool bAdd, bool bSubs, bool bDiv, bool bMult, bool bSqrRoot, bool bCube)
        {
            //I created this function, to replace common code. Very good practice to replace common code by a function, or method.
            iNumber = iDigit;
            iDigit = 0;
            bAddition = bAdd;
            bDivision = bDiv;
            bMultiplication = bMult;
            bSubtraction = bSubs;
            bSquareRoot = bSqrRoot;
            bCubeRoot = bCube;
 
            //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
            //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
            
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            
            ValueTextBox.Text += "-";
            szText += "-";
            //ProcessAction(false, true, false, false, false, false);

            bool bselect =  true;
            iNumber = iDigit;
            iDigit = 0;
            bAddition = false;
            bDivision = false;
            bMultiplication = false;
            bSubtraction = true;
            bSquareRoot = false;
            bCubeRoot = false;
            if (bselect)
            {
                //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
                //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
                ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
                ValueTextBox.SelectionLength = 0;
                ValueTextBox.Focus();
            }
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            ValueTextBox.Text += "+";
            szText += "+";
            //ProcessAction(true, false, false, false, false, false);

            bool bselect =  true;
            iNumber = iDigit;
            iDigit = 0;
            bAddition = true;
            bDivision = false;
            bMultiplication = false;
            bSubtraction = false;
            bSquareRoot = false;
            bCubeRoot = false;
            if (bselect)
            {
                //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
                //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
                ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
                ValueTextBox.SelectionLength = 0;
                ValueTextBox.Focus();
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            ValueTextBox.Text += "/";
            szText += "/";
            //ProcessAction(false, false, true, false, false, false);

            bool bselect =  true;
            iNumber = iDigit;
            iDigit = 0;
            bAddition = false;
            bDivision = true;
            bMultiplication = false;
            bSubtraction = false;
            bSquareRoot = false;
            bCubeRoot = false;
            if (bselect)
            {
                //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
                //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
                ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
                ValueTextBox.SelectionLength = 0;
                ValueTextBox.Focus();
            }
        }
    

        private void Multiplication_Click(object sender, EventArgs e)
        {
            ValueTextBox.Text += "x";
            szText += "x";
           // ProcessAction(false, false, false, true, false, false);


            iNumber = iDigit;
            iDigit = 0;
            bAddition = false;
            bDivision = false;
            bMultiplication = true;
            bSubtraction = false;
            bSquareRoot = false;
            bCubeRoot = false;
  
            //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
            //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
  


        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the user enters any characters different form a number, + ,-,x,/back space or space we show an error box
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' 
                && e.KeyChar != 'x' && e.KeyChar != 'X' && e.KeyChar != '/' && e.KeyChar != '=' 
                && e.KeyChar != '\b' //back space
                && e.KeyChar != '\n' // enter key
                && e.KeyChar != '\r' // carriage retuen key
                 && e.KeyChar != 0x20) //space
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid character");
                return;
            }
                szText += e.KeyChar;
            szText.Trim();
            if (char.IsDigit(e.KeyChar))
            {
                // for example,  here a character such as "2" does not have a value of 2. it has a value of 50. You will need to substract it by 48, wich is the value of character '0' (see ASCII table for all values)
                if (iDigit > 0)
                {
                    iDigit = (e.KeyChar - '0')  + (iDigit * 10); // for example, if the user presses 2 after he already pressed 1, 2 will replace 1 in the edit box. in order for the edit box to show 12, you need to add 1x10 to 2, which is 12
                }
                else
                {
                    iDigit = e.KeyChar - '0';


                }
            }
            else if (e.KeyChar == '+')
            {
               // ProcessAction(true, false, false, false, false, false);

                iNumber = iDigit;
                iDigit = 0;
                bAddition = true;
                bDivision = false;
                bMultiplication = false;
                bSubtraction = false;
                bSquareRoot = false;
                bCubeRoot = false;
 
                //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
                //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
                ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
                ValueTextBox.SelectionLength = 0;
                ValueTextBox.Focus();
                
            }
            else if (e.KeyChar == '-')
            {
               // ProcessAction(false, true, false, false, false, false);

                iNumber = iDigit;
                iDigit = 0;
                bAddition = false;
                bDivision = false;
                bMultiplication = false;
                bSubtraction = true;
                bSquareRoot = false;
                bCubeRoot = false;
   
                //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
                //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
                ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
                ValueTextBox.SelectionLength = 0;
                ValueTextBox.Focus();
                

            }
            else if (e.KeyChar == 'x')
            {
              //  ProcessAction(false, false, false, true, false, false);

                iNumber = iDigit;
                iDigit = 0;
                bAddition = false;
                bDivision = false;
                bMultiplication = true;
                bSubtraction = false;
                bSquareRoot = false;
                bCubeRoot = false;
 
                //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
                //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
                ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
                ValueTextBox.SelectionLength = 0;
                ValueTextBox.Focus();
                
            }
            else if (e.KeyChar == '/')
            {
                //ProcessAction(false, false, true, false, false, false);

  
                iNumber = iDigit;
                iDigit = 0;
                bAddition = false;
                bDivision = true;
                bMultiplication = false;
                bSubtraction = false;
                bSquareRoot = false;
                bCubeRoot = false;
 
                //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
                //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
                ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
                ValueTextBox.SelectionLength = 0;
                ValueTextBox.Focus();
                
            }
            if (e.KeyChar == '=' || e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                // user pressed typed the equal sign. iDigit is whatever he typed before the equal sign, and iNumber is the result of the operation (+,-,x or /)
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
                        // remember never divide by 0!! . If the user tries that, we show a message and return, otherwise the app will crash.
                        MessageBox.Show("Cannot devide by 0");
                        return;

                    }
                    iNumber /= iDigit;
                }
                else if(bSubtraction)
                {
                    iNumber -= iDigit;

                }
                //now that we got the result we save into the iDigit variable for subsequent operations, and reset iNumber
                iDigit = iNumber;
                iNumber = 0;
                if(e.KeyChar == '\n' || e.KeyChar == '\r')
                {
                    szText += "=";
                }
                szText += iDigit.ToString(); ;
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
            //user clicked on the Reset button, so reset everything
            ResetAll();


        }

        private void EqualOperator_Click(object sender, EventArgs e)
        {

            ValueTextBox.Text += "=";
            szText += "=";
            if (bAddition)
            {
                //user clicked on '+', add
                iNumber += iDigit;
            }
            else if (bMultiplication)
            {
                //user clicked on 'x', multiply
                iNumber *= iDigit;
            }
            else if (bSubtraction)
            {
                //user clicked on '-', substract
                iNumber -= iDigit;
            }
            else if (bDivision)
            {
                //user clicked on '/', divide but check first that he did not enter zero, a no no
                if (iDigit == 0)
                {
                    MessageBox.Show("Cannot devide by 0");
                    return;

                }
                iNumber /= iDigit;
            }
            if (bSquareRoot)
            {
                dNumber = Math.Sqrt(iDigit);
                szText += dNumber.ToString(); ;
                ValueTextBox.Text = szText;
            }
            else if (bCubeRoot)
            {
                dNumber = Math.Pow(iDigit, 1.0 / 3.0);
                szText += dNumber.ToString(); ;
                ValueTextBox.Text = szText;
            }
            else
            {
                iDigit = iNumber;
                iNumber = 0;
                //convert the result into a text, because the edit box take only characters, not numbers
                szText += iDigit.ToString(); ;
                ValueTextBox.Text = szText;
            }
            //here we need to move the mouse cursor to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
        }

       

     
        void ResetAll()
        {
            szText = "";
            ValueTextBox.Text = "";
            iNumber = 0;
            iDigit = 0;
            dNumber = 0;
        }

        private void SquareRoot_Click_1(object sender, EventArgs e)
        {
            ResetAll();
            ValueTextBox.Text += "sqr_root ";
            szText += "sqr_root ";
            //ProcessAction(false, false, false, false, true, false);

            iNumber = iDigit;
            iDigit = 0;
            bAddition = false;
            bDivision = false;
            bMultiplication = false;
            bSubtraction = false;
            bSquareRoot = true;
            bCubeRoot = false;

            //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
            //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
        }

        private void SquareRoot3_Click_1(object sender, EventArgs e)
        {
            ResetAll();
            ValueTextBox.Text += "cube_root ";
            szText += "cube_root ";
            // ProcessAction(false, false, false, false, false, true);

            iNumber = iDigit;
            iDigit = 0;
            bAddition = false;
            bDivision = false;
            bMultiplication = false;
            bSubtraction = false;
            bSquareRoot = false;
            bCubeRoot = true;

            //here the user is typing the equal sign, instead of pushing the '=' button, so we need to move the cursor 
            //to the end of the text in the edit box, so that when the types more characters, they are written where the cursor is , at the end of the existing text
            ValueTextBox.SelectionStart = ValueTextBox.Text.Length;
            ValueTextBox.SelectionLength = 0;
            ValueTextBox.Focus();
        }
    }
}
