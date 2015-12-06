using System;
using System.Drawing;
using System.Windows.Forms;

namespace P7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = this.MaximizeBox = false;
            this.Size = new Size(278, 296);
            Panel[] panels = new Panel[9];
            Label[] labels = new Label[9];
            Cursor[] cursors = { Cursors.Arrow, Cursors.Cross, Cursors.Hand, Cursors.Help, Cursors.IBeam, Cursors.No, Cursors.PanEast, Cursors.SizeAll, Cursors.WaitCursor };
            for (int i = 0; i < 9; i++)
            {
                panels[i] = new Panel();
                panels[i].Size = new Size(90, 90);
                panels[i].Location = new Point((i % 3) * 90, (i / 3) * 90);
                panels[i].Cursor = cursors[i];
                labels[i] = new Label();
                labels[i].Text = cursors[i].ToString();
                panels[i].Controls.Add(labels[i]);
                this.Controls.Add(panels[i]);
                panels[i].BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
}
