using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        private double number1, number2, finalAnswer;
        private String mathOperator;

       

        public Calculator()
        {
            InitializeComponent();
        }



        // Determines valid input to obtain or ignore from keyboard
        private void InputKeyPress(object sender, KeyPressEventArgs e)
        {
            String validInput = ".0123456789+-x/";
            String keyInput = e.KeyChar.ToString();

            // IF the input from keyboard is contained by the String validInput
            // Ignore the duplicate input
            // SWITCH STATMENT to perform action event corresponding to which valid form of input is used.

            if (validInput.Contains(keyInput))
            {

                e.Handled = true;

                switch (keyInput)
                {
                    case ".":
                        bButtonDecimal.PerformClick();
                        break;

                    // Backspace
                    case "":
                        if (inputTextBox.Text != "")
                        {
                            inputTextBox.Text = inputTextBox.Text.Remove(inputTextBox.Text.Length - 1, 1);
                        }
                        
                        break;

                    case "+":
                        bButtonAdd.PerformClick();
                        break;

                    case "-":
                        bButtonSubtract.PerformClick();
                        break;

                    case "x":
                        bButtonMultiply.PerformClick();
                        break;

                    case "/":
                        bButtonDivide.PerformClick();
                        break;



                    default:
                        inputTextBox.Text += keyInput;
                        break;

                }

            }
            // IF input is not contained within String validInput, ignore the event.
            else
            {
                // Ignore event
                e.Handled = true;
            }
        }






        // Number Button Click Event Handler
        private void NumberButton_Click(object sender, EventArgs e)
        {  
            Button button = (Button)sender;
            inputTextBox.Text = inputTextBox.Text + button.Text;

        }


        // Negative Button Click Event Handler
        private void NegativeButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Contains("-"))
            {
                // Take the negative-sign away from the number
                inputTextBox.Text = inputTextBox.Text.Remove(0,1);
            }
            else
            {
                // Add the negative-sign to the number
                inputTextBox.Text = inputTextBox.Text.Insert(0, "-");
            }
        }




        // Mathematical Operations Button Click Event Handler (Add, Subtract, Multiply, Divide)
        private void OperatorButton_Click(object sender, EventArgs e)
        {

            try
            {
                // If there is no input in the textbox (1st number) OR if a Math Operator has already been declared
                if (inputTextBox.Text == "" || inputTextBox.Text.Equals(".") || string.IsNullOrEmpty(mathOperator).Equals(false))
                {
                    // Throw Exception Error
                    throw new Exception("A required input value is missing.");

                }

                else
                {

                    Button button = (Button)sender;
                    Double.TryParse(inputTextBox.Text, out number1);
                    mathOperator = button.Text;
                    inputTextBox.Clear();
                    inputTextBox.Text = "";
                    inputTextBox.Select();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                inputTextBox.Select();
            }

        }




        // Equals Button Click Event Handler
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {

                // If a Math Operator hasn't been selected or the textBox is empty (There is no 2nd number)
                if (string.IsNullOrEmpty(mathOperator).Equals(true) && inputTextBox.Text.Equals("") || inputTextBox.Text.Equals("."))
                {

                    //Throw an Exception Error
                    throw new Exception ("A required input value is missing.");
                }
                else
                {
                    Double.TryParse(inputTextBox.Text, out number2);

                    // Method for calculating final answer (number1, number2, mathOperator)
                    finalAnswer = Math.Round(CalculateAnswer(number1, number2, mathOperator), 2);

                    // Clear mathOperator in order to use finalAnswer in next calculation.
                    mathOperator = "";
                    inputTextBox.Text = finalAnswer.ToString();
                    inputTextBox.Select();
                    

                }
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                inputTextBox.Select();
            }
        }

        // Decimal Button Click Event Handler
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Contains("."))
            {
                // Ignore the input
            }
            else
            {
                // Allow decimal to be inputed into text
                Button button = (Button)sender;
                inputTextBox.Text = inputTextBox.Text + button.Text;
            }
            inputTextBox.Select();
        }



        // METHOD "CalculateAnswer" performs 1 of 4 mathematical functions depending on which MathOperator was chosen.
        private double CalculateAnswer(double num1, double num2, String MathOperator) 
        {
            switch (MathOperator)
            {
                case "+":
                    return num1 + num2;

                case "-":
                    return num1 - num2;

                case "x":
                    return num1 * num2;

                case "/":
                    return num1 / num2;

            }
            return 0;

        }



        // Reset Button Click Event Handler
        private void ResetButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            number1 = 0;
            number2 = 0;
            mathOperator = "";
            inputTextBox.Select();
        }
    }
}
