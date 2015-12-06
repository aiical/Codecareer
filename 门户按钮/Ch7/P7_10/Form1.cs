using System;
using System.Drawing;
using System.Windows.Forms;

namespace P7_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            menuItemWindowMiddle.Checked = true;
            menuItemWindowBig.Click += menuItem_Click;
            menuItemWindowMiddle.Click += menuItem_Click;
            menuItemWindowSmall.Click += menuItem_Click;
        }

        void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item == menuItemWindowBig)
            {
                menuItemWindowBig.Checked = true;
                menuItemWindowMiddle.Checked = menuItemWindowSmall.Checked = false;
                this.Size = new Size(800, 450);
            }
            else if (item == menuItemWindowMiddle)
            {
                menuItemWindowMiddle.Checked = true;
                menuItemWindowBig.Checked = menuItemWindowSmall.Checked = false;
                this.Size = new Size(480, 270);
            }
            else if (item == menuItemWindowSmall)
            {
                menuItemWindowSmall.Checked = true;
                menuItemWindowBig.Checked = menuItemWindowMiddle.Checked = false;
                this.Size = new Size(240, 135);
            }
        }
    }
}
