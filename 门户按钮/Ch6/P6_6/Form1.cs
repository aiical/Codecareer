using System;
using System.Windows.Forms;

namespace P6_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(button_Click);
            this.button2.Click += new EventHandler(button_Click);
            this.button3.Click += new EventHandler(button_Click);
        }

        void button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "您按下了" + ((Button)sender).Text;
        }
    }
}
