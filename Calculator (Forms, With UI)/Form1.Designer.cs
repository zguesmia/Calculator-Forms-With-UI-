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
            this.SuspendLayout();
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication.Location = new System.Drawing.Point(17, 327);
            this.Multiplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(49, 47);
            this.Multiplication.TabIndex = 0;
            this.Multiplication.Text = "X";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(17, 263);
            this.Division.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(49, 47);
            this.Division.TabIndex = 2;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.Location = new System.Drawing.Point(17, 198);
            this.Addition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(49, 47);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction.Location = new System.Drawing.Point(17, 132);
            this.Subtraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(49, 47);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTextBox.Location = new System.Drawing.Point(26, 10);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(456, 61);
            this.ValueTextBox.TabIndex = 5;
            this.ValueTextBox.Text = "";
            this.ValueTextBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            this.ValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTextBox_KeyPress);
            // 
            // EqualOperator
            // 
            this.EqualOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EqualOperator.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualOperator.Location = new System.Drawing.Point(432, 327);
            this.EqualOperator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EqualOperator.Name = "EqualOperator";
            this.EqualOperator.Size = new System.Drawing.Size(49, 47);
            this.EqualOperator.TabIndex = 6;
            this.EqualOperator.Text = "=";
            this.EqualOperator.UseVisualStyleBackColor = true;
            this.EqualOperator.Click += new System.EventHandler(this.EqualOperator_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRoot.Location = new System.Drawing.Point(86, 132);
            this.SquareRoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(49, 47);
            this.SquareRoot.TabIndex = 7;
            this.SquareRoot.Text = "SqRt/2";
            this.SquareRoot.UseVisualStyleBackColor = true;
            // 
            // SquareRoot3
            // 
            this.SquareRoot3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRoot3.Location = new System.Drawing.Point(86, 198);
            this.SquareRoot3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SquareRoot3.Name = "SquareRoot3";
            this.SquareRoot3.Size = new System.Drawing.Size(49, 47);
            this.SquareRoot3.TabIndex = 8;
            this.SquareRoot3.Text = "SqRt/3";
            this.SquareRoot3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(507, 391);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

