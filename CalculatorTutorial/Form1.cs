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

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText("0");
        }
    }
}
