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
            this.SuspendLayout();
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication.Location = new System.Drawing.Point(23, 402);
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
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(606, 74);
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
            this.EqualOperator.Name = "EqualOperator";
            this.EqualOperator.Size = new System.Drawing.Size(65, 58);
            this.EqualOperator.TabIndex = 6;
            this.EqualOperator.Text = "=";
            this.EqualOperator.UseVisualStyleBackColor = true;
            // 
            // SquareRoot
            // 
            this.SquareRoot.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRoot.Location = new System.Drawing.Point(114, 162);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(65, 58);
            this.SquareRoot.TabIndex = 7;
            this.SquareRoot.Text = "SqRt/2";
            this.SquareRoot.UseVisualStyleBackColor = true;
            // 
            // SquareRoot3
            // 
            this.SquareRoot3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRoot3.Location = new System.Drawing.Point(114, 244);
            this.SquareRoot3.Name = "SquareRoot3";
            this.SquareRoot3.Size = new System.Drawing.Size(65, 58);
            this.SquareRoot3.TabIndex = 8;
            this.SquareRoot3.Text = "SqRt/3";
            this.SquareRoot3.UseVisualStyleBackColor = true;
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(676, 481);
            this.Controls.Add(this.SquareRoot3);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.EqualOperator);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
    }
}

