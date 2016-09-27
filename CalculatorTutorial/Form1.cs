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

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string digit = button.Text;

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = digit;
            }
            else
            {
                txtDisplay.AppendText(digit);
            }
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(".");
            //btnDP.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            //btnDP.Enabled = true;
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
    }
}
