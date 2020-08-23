namespace Calculator
{
    partial class Calculator
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.bButton0 = new System.Windows.Forms.Button();
            this.bButton1 = new System.Windows.Forms.Button();
            this.bButton2 = new System.Windows.Forms.Button();
            this.bButton3 = new System.Windows.Forms.Button();
            this.bButtonDecimal = new System.Windows.Forms.Button();
            this.bButton4 = new System.Windows.Forms.Button();
            this.bButton5 = new System.Windows.Forms.Button();
            this.bButton6 = new System.Windows.Forms.Button();
            this.bButton7 = new System.Windows.Forms.Button();
            this.bButton8 = new System.Windows.Forms.Button();
            this.bButton9 = new System.Windows.Forms.Button();
            this.bButtonReset = new System.Windows.Forms.Button();
            this.bButtonNegative = new System.Windows.Forms.Button();
            this.bButtonEquals = new System.Windows.Forms.Button();
            this.bButtonAdd = new System.Windows.Forms.Button();
            this.bButtonSubtract = new System.Windows.Forms.Button();
            this.bButtonMultiply = new System.Windows.Forms.Button();
            this.bButtonDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(16, 15);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ShortcutsEnabled = false;
            this.inputTextBox.Size = new System.Drawing.Size(295, 22);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputKeyPress);
            // 
            // bButton0
            // 
            this.bButton0.Location = new System.Drawing.Point(21, 190);
            this.bButton0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton0.Name = "bButton0";
            this.bButton0.Size = new System.Drawing.Size(141, 28);
            this.bButton0.TabIndex = 3;
            this.bButton0.Text = "0";
            this.bButton0.UseVisualStyleBackColor = true;
            this.bButton0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButton1
            // 
            this.bButton1.Location = new System.Drawing.Point(21, 154);
            this.bButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton1.Name = "bButton1";
            this.bButton1.Size = new System.Drawing.Size(67, 28);
            this.bButton1.TabIndex = 4;
            this.bButton1.Text = "1";
            this.bButton1.UseVisualStyleBackColor = true;
            this.bButton1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButton2
            // 
            this.bButton2.Location = new System.Drawing.Point(96, 154);
            this.bButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton2.Name = "bButton2";
            this.bButton2.Size = new System.Drawing.Size(67, 28);
            this.bButton2.TabIndex = 5;
            this.bButton2.Text = "2";
            this.bButton2.UseVisualStyleBackColor = true;
            this.bButton2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButton3
            // 
            this.bButton3.Location = new System.Drawing.Point(171, 154);
            this.bButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton3.Name = "bButton3";
            this.bButton3.Size = new System.Drawing.Size(67, 28);
            this.bButton3.TabIndex = 6;
            this.bButton3.Text = "3";
            this.bButton3.UseVisualStyleBackColor = true;
            this.bButton3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButtonDecimal
            // 
            this.bButtonDecimal.Location = new System.Drawing.Point(171, 190);
            this.bButtonDecimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButtonDecimal.Name = "bButtonDecimal";
            this.bButtonDecimal.Size = new System.Drawing.Size(67, 28);
            this.bButtonDecimal.TabIndex = 2;
            this.bButtonDecimal.Text = ".";
            this.bButtonDecimal.UseVisualStyleBackColor = true;
            this.bButtonDecimal.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // bButton4
            // 
            this.bButton4.Location = new System.Drawing.Point(21, 118);
            this.bButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton4.Name = "bButton4";
            this.bButton4.Size = new System.Drawing.Size(67, 28);
            this.bButton4.TabIndex = 7;
            this.bButton4.Text = "4";
            this.bButton4.UseVisualStyleBackColor = true;
            this.bButton4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButton5
            // 
            this.bButton5.Location = new System.Drawing.Point(96, 118);
            this.bButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton5.Name = "bButton5";
            this.bButton5.Size = new System.Drawing.Size(67, 28);
            this.bButton5.TabIndex = 8;
            this.bButton5.Text = "5";
            this.bButton5.UseVisualStyleBackColor = true;
            this.bButton5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButton6
            // 
            this.bButton6.Location = new System.Drawing.Point(171, 118);
            this.bButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton6.Name = "bButton6";
            this.bButton6.Size = new System.Drawing.Size(67, 28);
            this.bButton6.TabIndex = 9;
            this.bButton6.Text = "6";
            this.bButton6.UseVisualStyleBackColor = true;
            this.bButton6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButton7
            // 
            this.bButton7.Location = new System.Drawing.Point(21, 82);
            this.bButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton7.Name = "bButton7";
            this.bButton7.Size = new System.Drawing.Size(67, 28);
            this.bButton7.TabIndex = 10;
            this.bButton7.Text = "7";
            this.bButton7.UseVisualStyleBackColor = true;
            this.bButton7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButton8
            // 
            this.bButton8.Location = new System.Drawing.Point(96, 82);
            this.bButton8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton8.Name = "bButton8";
            this.bButton8.Size = new System.Drawing.Size(67, 28);
            this.bButton8.TabIndex = 11;
            this.bButton8.Text = "8";
            this.bButton8.UseVisualStyleBackColor = true;
            this.bButton8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButton9
            // 
            this.bButton9.Location = new System.Drawing.Point(171, 82);
            this.bButton9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButton9.Name = "bButton9";
            this.bButton9.Size = new System.Drawing.Size(67, 28);
            this.bButton9.TabIndex = 12;
            this.bButton9.Text = "9";
            this.bButton9.UseVisualStyleBackColor = true;
            this.bButton9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bButtonReset
            // 
            this.bButtonReset.Location = new System.Drawing.Point(21, 47);
            this.bButtonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButtonReset.Name = "bButtonReset";
            this.bButtonReset.Size = new System.Drawing.Size(67, 28);
            this.bButtonReset.TabIndex = 18;
            this.bButtonReset.Text = "Reset";
            this.bButtonReset.UseVisualStyleBackColor = true;
            this.bButtonReset.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // bButtonNegative
            // 
            this.bButtonNegative.Location = new System.Drawing.Point(96, 47);
            this.bButtonNegative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButtonNegative.Name = "bButtonNegative";
            this.bButtonNegative.Size = new System.Drawing.Size(67, 28);
            this.bButtonNegative.TabIndex = 1;
            this.bButtonNegative.Text = "-/+";
            this.bButtonNegative.UseVisualStyleBackColor = true;
            this.bButtonNegative.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // bButtonEquals
            // 
            this.bButtonEquals.Location = new System.Drawing.Point(245, 190);
            this.bButtonEquals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButtonEquals.Name = "bButtonEquals";
            this.bButtonEquals.Size = new System.Drawing.Size(67, 28);
            this.bButtonEquals.TabIndex = 17;
            this.bButtonEquals.Text = "=";
            this.bButtonEquals.UseVisualStyleBackColor = true;
            this.bButtonEquals.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // bButtonAdd
            // 
            this.bButtonAdd.Location = new System.Drawing.Point(245, 154);
            this.bButtonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButtonAdd.Name = "bButtonAdd";
            this.bButtonAdd.Size = new System.Drawing.Size(67, 28);
            this.bButtonAdd.TabIndex = 13;
            this.bButtonAdd.Text = "+";
            this.bButtonAdd.UseVisualStyleBackColor = true;
            this.bButtonAdd.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // bButtonSubtract
            // 
            this.bButtonSubtract.Location = new System.Drawing.Point(245, 118);
            this.bButtonSubtract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButtonSubtract.Name = "bButtonSubtract";
            this.bButtonSubtract.Size = new System.Drawing.Size(67, 28);
            this.bButtonSubtract.TabIndex = 14;
            this.bButtonSubtract.Text = "-";
            this.bButtonSubtract.UseVisualStyleBackColor = true;
            this.bButtonSubtract.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // bButtonMultiply
            // 
            this.bButtonMultiply.Location = new System.Drawing.Point(245, 82);
            this.bButtonMultiply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButtonMultiply.Name = "bButtonMultiply";
            this.bButtonMultiply.Size = new System.Drawing.Size(67, 28);
            this.bButtonMultiply.TabIndex = 15;
            this.bButtonMultiply.Text = "x";
            this.bButtonMultiply.UseVisualStyleBackColor = true;
            this.bButtonMultiply.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // bButtonDivide
            // 
            this.bButtonDivide.Location = new System.Drawing.Point(245, 47);
            this.bButtonDivide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bButtonDivide.Name = "bButtonDivide";
            this.bButtonDivide.Size = new System.Drawing.Size(67, 28);
            this.bButtonDivide.TabIndex = 16;
            this.bButtonDivide.Text = "/";
            this.bButtonDivide.UseVisualStyleBackColor = true;
            this.bButtonDivide.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 249);
            this.Controls.Add(this.bButtonDivide);
            this.Controls.Add(this.bButtonMultiply);
            this.Controls.Add(this.bButtonSubtract);
            this.Controls.Add(this.bButtonAdd);
            this.Controls.Add(this.bButtonEquals);
            this.Controls.Add(this.bButtonNegative);
            this.Controls.Add(this.bButtonReset);
            this.Controls.Add(this.bButton9);
            this.Controls.Add(this.bButton8);
            this.Controls.Add(this.bButton7);
            this.Controls.Add(this.bButton6);
            this.Controls.Add(this.bButton5);
            this.Controls.Add(this.bButton4);
            this.Controls.Add(this.bButtonDecimal);
            this.Controls.Add(this.bButton3);
            this.Controls.Add(this.bButton2);
            this.Controls.Add(this.bButton1);
            this.Controls.Add(this.bButton0);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button bButton0;
        private System.Windows.Forms.Button bButton1;
        private System.Windows.Forms.Button bButton2;
        private System.Windows.Forms.Button bButton3;
        private System.Windows.Forms.Button bButtonDecimal;
        private System.Windows.Forms.Button bButton4;
        private System.Windows.Forms.Button bButton5;
        private System.Windows.Forms.Button bButton6;
        private System.Windows.Forms.Button bButton7;
        private System.Windows.Forms.Button bButton8;
        private System.Windows.Forms.Button bButton9;
        private System.Windows.Forms.Button bButtonReset;
        private System.Windows.Forms.Button bButtonNegative;
        private System.Windows.Forms.Button bButtonEquals;
        private System.Windows.Forms.Button bButtonAdd;
        private System.Windows.Forms.Button bButtonSubtract;
        private System.Windows.Forms.Button bButtonMultiply;
        private System.Windows.Forms.Button bButtonDivide;
    }
}

