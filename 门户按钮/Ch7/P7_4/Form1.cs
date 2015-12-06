using System;
using System.Windows.Forms;

namespace P7_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.KeyPress += textBox1_KeyPress;
        }

        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar < 127)
                label1.Text = e.KeyChar.ToString() + label1.Text;
            if (e.KeyChar == '\b' && label1.Text.Length > 0)
                label1.Text = label1.Text.Remove(0, 1);
        }
    }
}
