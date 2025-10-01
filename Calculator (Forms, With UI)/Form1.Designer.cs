namespace Calculator__Forms__With_UI_
{
    partial class CalculatorApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.ValueTextBox = new System.Windows.Forms.RichTextBox();
            this.EqualOperator = new System.Windows.Forms.Button();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.SquareRoot3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication.Location = new System.Drawing.Point(23, 402);
            this.Multiplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(65, 58);
            this.Multiplication.TabIndex = 0;
            this.Multiplication.Text = "X";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(23, 324);
            this.Division.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(65, 58);
            this.Division.TabIndex = 2;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.Location = new System.Drawing.Point(23, 244);
            this.Addition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(65, 58);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction.Location = new System.Drawing.Point(23, 162);
            this.Subtraction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(65, 58);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTextBox.Location = new System.Drawing.Point(35, 12);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(607, 74);
            this.ValueTextBox.TabIndex = 5;
            this.ValueTextBox.Text = "";
            this.ValueTextBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            this.ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTextBox_KeyPress);
            // 
            // EqualOperator
            // 
            this.EqualOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EqualOperator.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualOperator.Location = new System.Drawing.Point(576, 402);
            this.EqualOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EqualOperator.Name = "EqualOperator";
            this.EqualOperator.Size = new System.Drawing.Size(65, 58);
            this.EqualOperator.TabIndex = 6;
            this.EqualOperator.Text = "=";
            this.EqualOperator.UseVisualStyleBackColor = true;
            this.EqualOperator.Click += new System.EventHandler(this.EqualOperator_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRoot.Location = new System.Drawing.Point(115, 162);
            this.SquareRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(65, 58);
            this.SquareRoot.TabIndex = 7;
            this.SquareRoot.Text = "SqRt/2";
            this.SquareRoot.UseVisualStyleBackColor = true;
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click_1);
            // 
            // SquareRoot3
            // 
            this.SquareRoot3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRoot3.Location = new System.Drawing.Point(115, 244);
            this.SquareRoot3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SquareRoot3.Name = "SquareRoot3";
            this.SquareRoot3.Size = new System.Drawing.Size(65, 58);
            this.SquareRoot3.TabIndex = 8;
            this.SquareRoot3.Text = "SqRt/3";
            this.SquareRoot3.UseVisualStyleBackColor = true;
            this.SquareRoot3.Click += new System.EventHandler(this.SquareRoot3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(199, 162);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(65, 58);
            this.One.TabIndex = 10;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(281, 162);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(65, 58);
            this.Two.TabIndex = 11;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(363, 162);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(65, 58);
            this.Three.TabIndex = 12;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(199, 244);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(65, 58);
            this.Four.TabIndex = 13;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(281, 244);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(65, 58);
            this.Five.TabIndex = 14;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(363, 244);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(65, 58);
            this.Six.TabIndex = 15;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(199, 324);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(65, 58);
            this.Seven.TabIndex = 16;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(281, 324);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(65, 58);
            this.Eight.TabIndex = 17;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(363, 324);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(65, 58);
            this.Nine.TabIndex = 18;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(676, 481);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SquareRoot3);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.EqualOperator);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalculatorApp";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.RichTextBox ValueTextBox;
        private System.Windows.Forms.Button EqualOperator;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button SquareRoot3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
    }
}

