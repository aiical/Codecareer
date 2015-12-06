namespace P7_10
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindowBig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindowMiddle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindowSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemWindowBig,
            this.menuItemWindowMiddle,
            this.menuItemWindowSmall});
            this.menuItemWindow.Name = "menuItemWindow";
            this.menuItemWindow.Size = new System.Drawing.Size(59, 20);
            this.menuItemWindow.Text = "窗口(&W)";
            // 
            // menuItemWindowBig
            // 
            this.menuItemWindowBig.Name = "menuItemWindowBig";
            this.menuItemWindowBig.Size = new System.Drawing.Size(152, 22);
            this.menuItemWindowBig.Text = "大(&B)";
            // 
            // menuItemWindowMiddle
            // 
            this.menuItemWindowMiddle.Name = "menuItemWindowMiddle";
            this.menuItemWindowMiddle.Size = new System.Drawing.Size(152, 22);
            this.menuItemWindowMiddle.Text = "中(M)";
            // 
            // menuItemWindowSmall
            // 
            this.menuItemWindowSmall.Name = "menuItemWindowSmall";
            this.menuItemWindowSmall.Size = new System.Drawing.Size(152, 22);
            this.menuItemWindowSmall.Text = "小(S)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 243);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindowBig;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindowMiddle;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindowSmall;
    }
}

