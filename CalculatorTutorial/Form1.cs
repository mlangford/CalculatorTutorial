using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double memoryValue = 0.0;
        bool clearDisplay = true;
        bool isFirstValue = true;
        bool isAfterEqual = false;

        double currentAnswer;
        double lastValueEntered;
        char lastOp;

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string digit = button.Text;

            if (clearDisplay)
            {
                txtDisplay.Text = digit;
                clearDisplay = false;
            }
            else
            {
                txtDisplay.AppendText(digit);
            }
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            if (clearDisplay)
            {
                txtDisplay.Text = "0.";
                clearDisplay = false;
            }
            else
            {
                txtDisplay.AppendText(".");
                //btnDP.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            clearDisplay = true;
            btnDP.Enabled = true;

            isFirstValue = true;
            isAfterEqual = false;
            //btnDP.Enabled = true;
            currentAnswer= 0;
        }

        private void btnMadd_Click(object sender, EventArgs e)
        {
            memoryValue += Convert.ToDouble(txtDisplay.Text);
        }

        private void btnMsub_Click(object sender, EventArgs e)
        {
            memoryValue += Convert.ToDouble(txtDisplay.Text);
        }

        private void btmMclr_Click(object sender, EventArgs e)
        {
            memoryValue = 0.0;
        }

        private void btnMrec_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoryValue.ToString();
        }

        private void btnBksp_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            btnDP.Enabled = !txtDisplay.Text.Contains(".");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearDisplay = true;
            btnDP.Enabled = true;

            if (isFirstValue)
            {
                currentAnswer = Convert.ToDouble(txtDisplay.Text);
                isFirstValue = false;
                lastOp = '+';
                isAfterEqual = false;
            }
            else
            {
                lastValueEntered = Convert.ToDouble(txtDisplay.Text);
                switch (lastOp)
                    {
                    case '+':
                        currentAnswer += lastValueEntered;
                        break;
                    case '-':
                        currentAnswer -= lastValueEntered;
                        break;
                    case '*':
                        currentAnswer *= lastValueEntered;
                        break;
                    case '/':
                        currentAnswer /= lastValueEntered;
                        break;
                }
            }

            lastOp = '+';
            isAfterEqual = false;
            txtDisplay.Text = currentAnswer.ToString();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            clearDisplay = true;

            if (isAfterEqual==false)
            {
                lastValueEntered = Convert.ToDouble(txtDisplay.Text);
                isAfterEqual = true;
            }



            if (lastOp == '+')
            {
                currentAnswer += lastValueEntered;
            }

            txtDisplay.Text = currentAnswer.ToString();
            isFirstValue = true;
        }
    }
}
