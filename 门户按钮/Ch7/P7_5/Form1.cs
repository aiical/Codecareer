using System;
using System.Drawing;
using System.Windows.Forms;

namespace P7_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                button1.FlatStyle = FlatStyle.Standard;
            else
                button1.FlatStyle = FlatStyle.Flat;
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button1.TextAlign = ContentAlignment.MiddleCenter;
                button1.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else if (radioButton2.Checked)
            {
                button1.TextAlign = ContentAlignment.MiddleLeft;
                button1.ImageAlign = ContentAlignment.MiddleRight;
            }
            else if (radioButton3.Checked)
            {
                button1.TextAlign = ContentAlignment.MiddleRight;
                button1.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
    }
}
