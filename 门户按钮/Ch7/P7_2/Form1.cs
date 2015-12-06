using System;
using System.Windows.Forms;

namespace P7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; 
        }

        void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("要进入程序吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                this.Close();
            else
                this.FormClosing += Form1_FormClosing;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
