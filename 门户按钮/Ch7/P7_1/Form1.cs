using System;
using System.Drawing;
using System.Windows.Forms;

namespace P7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LocationChanged += new EventHandler(Form1_LocationChanged);
            SizeChanged += new EventHandler(Form1_SizeChanged);
        }

        void Form1_LocationChanged(object sender, EventArgs e)
        {
            this.Text = "窗体位置: " + this.Location.ToString();
        }

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Text = "窗体尺寸: " + this.Size.ToString();
        }
    }
}
