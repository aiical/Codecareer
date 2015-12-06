using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace P7_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click; 
        }

        void button1_Click(object sender, EventArgs e)
        {
            int i = EmphAllCtrls(this);
            MessageBox.Show(string.Format("共处理{0}个控件", i));
        }

        public int EmphAllCtrls(Control ctrl)
        {
            int i = 0;
            foreach (Control c in ctrl.Controls)
            {
                c.Font = new Font(c.Font, FontStyle.Bold | FontStyle.Italic);
                i++;
                if (c.HasChildren)
                    i += EmphAllCtrls(c);
            }
            return i;
        }
    }
}
