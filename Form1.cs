using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VirtualKeyboard
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x08000000;
                return createParams;
            }
        }

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("Q");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SendKeys.Send("W");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SendKeys.Send("E");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SendKeys.Send("R");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SendKeys.Send("T");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SendKeys.Send("Y");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SendKeys.Send("U");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SendKeys.Send("I");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SendKeys.Send("O");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SendKeys.Send("P");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("A");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            SendKeys.Send("S");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            SendKeys.Send("D");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            SendKeys.Send("F");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            SendKeys.Send("G");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SendKeys.Send("H");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SendKeys.Send("J");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            SendKeys.Send("K");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            SendKeys.Send("L");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            SendKeys.Send("Z");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            SendKeys.Send("X");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            SendKeys.Send("C");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            SendKeys.Send("V");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            SendKeys.Send("B");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            SendKeys.Send("N");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            SendKeys.Send("M");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{backspace}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            SendKeys.Send("@");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            SendKeys.Send(".");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            SendKeys.Send("-");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            SendKeys.Send("_");
        }        
    }
}
