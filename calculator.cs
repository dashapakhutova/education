using System;
using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string expression = "";
        bool isFirstInputAfterOperation = false;
        bool hasComma = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isFirstInputAfterOperation)
            {
                isFirstInputAfterOperation = false;
            }

            textBox1.Text += button.Text;
            expression += button.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            expression = "";
            isFirstInputAfterOperation = false;
            hasComma = false;
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text += " " + button.Text + " ";
                expression += button.Text;
                isFirstInputAfterOperation = true;
                hasComma = false;
            }
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");
                textBox1.Text = result.ToString();
                expression = result.ToString();
                isFirstInputAfterOperation = true;
                hasComma = expression.Contains(".");
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка";
                expression = "";
                isFirstInputAfterOperation = false;
                hasComma = false;
            }
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (!hasComma)
            {
                textBox1.Text += ",";
                expression += ".";
                hasComma = true;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" || !isFirstInputAfterOperation)
            {
                textBox1.Text += "0";
                expression += "0";
            }
        }
    }
}
