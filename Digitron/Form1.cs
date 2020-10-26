using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Digitron
{
    public partial class Form1 : Form
    {
        private static readonly List<char> unrepeatable = new List<char> {'+', '-', '*', '/', '.'};
        private static readonly List<char> cantStartWith = new List<char> {'*', '/'};
        private readonly StringBuilder expression = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ClickZero(object sender, EventArgs e)
        {
            AppendToExpression('0');
        }

        private void ClickOne(object sender, EventArgs e)
        {
            AppendToExpression('1');
        }

        private void ClickTwo(object sender, EventArgs e)
        {
            AppendToExpression('2');
        }

        private void ClickThree(object sender, EventArgs e)
        {
            AppendToExpression('3');
        }

        private void ClickFour(object sender, EventArgs e)
        {
            AppendToExpression('4');
        }

        private void ClickFive(object sender, EventArgs e)
        {
            AppendToExpression('5');
        }

        private void ClickSix(object sender, EventArgs e)
        {
            AppendToExpression('6');
        }

        private void ClickSeven(object sender, EventArgs e)
        {
            AppendToExpression('7');
        }

        private void ClickEight(object sender, EventArgs e)
        {
            AppendToExpression('8');
        }

        private void ClickNine(object sender, EventArgs e)
        {
            AppendToExpression('9');
        }

        private void ClickPlus(object sender, EventArgs e)
        {
            AppendToExpression('+');
        }

        private void ClickMinus(object sender, EventArgs e)
        {
            AppendToExpression('-');
        }

        private void ClickDivide(object sender, EventArgs e)
        {
            AppendToExpression('/');
        }

        private void ClickMultiply(object sender, EventArgs e)
        {
            AppendToExpression('*');
        }

        private void ClickDecimalPoint(object sender, EventArgs e)
        {
            AppendToExpression('.');
        }

        private void ClickEquals(object sender, EventArgs e)
        {
            double expressionResult;
            
            // Calculating the expression
            try
            {
                expressionResult = Convert.ToDouble(new DataTable().Compute(expression.ToString(), null));
            }
            catch (SyntaxErrorException exception)
            {
                UpdateText("Syntax error:\n" + exception.Message);
                return;
            }

            string resultString = expressionResult.ToString(CultureInfo.InvariantCulture);
            UpdateText(resultString);
            expression.Clear().Append(resultString);
        }

        private void ClickBack(object sender, EventArgs e)
        {
            RemoveLastCharacterFromExpression();
        }

        private void ClickClear(object sender, EventArgs e)
        {
            ClearExpression();
        }
        
        private void ClickCredit(object? sender, EventArgs e)
        {
            MessageBox.Show("Digitron napravio Ivan Cerovina", "Digitron");
        }

        private void AppendToExpression(char character)
        {
            // checking if the expression starts with characters besides + and -
            if (expression.Length == 0 && cantStartWith.Contains(character)) return;

            // checking if the last character is a symbol, so
            //  the symbols dont double up
            if (unrepeatable.Contains(character) && expression.Length != 0 &&
                unrepeatable.Contains(expression.ToString()[expression.Length - 1]))
                expression.Remove(expression.Length - 1, 1);

            // adding the symbol to the result
            expression.Append(character);
            UpdateText(expression.ToString());
        }

        private void RemoveLastCharacterFromExpression()
        {
            if (expression.Length == 0) return;

            expression.Remove(expression.Length - 1, 1);
            result.Text = expression.ToString();
        }

        private void ClearExpression()
        {
            expression.Clear();
            UpdateText(expression.ToString());
        }

        private void UpdateText(string text)
        {
            var size = 24 - text.Length / 2;
            var font = new Font("Arial", size > 10 ? size : 11);

            result.Font = font;
            result.Text = text;
        }
    }
}