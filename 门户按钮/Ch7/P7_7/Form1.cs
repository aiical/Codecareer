using System;
using System.Drawing;
using System.Windows.Forms;

namespace P7_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar2.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar3.ValueChanged += new EventHandler(trackBar_ValueChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.Text = "窗体背景色:(0,0,0)";
        }

        void trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.Text = string.Format("窗体背景色:({0},{1},{2})", this.BackColor.R, this.BackColor.G, this.BackColor.B);
        }
    }
}
