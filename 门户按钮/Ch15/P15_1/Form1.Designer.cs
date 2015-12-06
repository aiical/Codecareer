namespace P15_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbOrderField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.cmbFilterField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbOrderField);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.cmbOperator);
            this.panel1.Controls.Add(this.cmbFilterField);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 75);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "筛选";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbOrderField
            // 
            this.cmbOrderField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderField.FormattingEnabled = true;
            this.cmbOrderField.Items.AddRange(new object[] {
            "姓名",
            "年龄",
            "工资"});
            this.cmbOrderField.Location = new System.Drawing.Point(70, 37);
            this.cmbOrderField.Name = "cmbOrderField";
            this.cmbOrderField.Size = new System.Drawing.Size(100, 20);
            this.cmbOrderField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "排序依据:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(250, 6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 21);
            this.numericUpDown1.TabIndex = 3;
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.cmbOperator.Location = new System.Drawing.Point(180, 6);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(60, 20);
            this.cmbOperator.TabIndex = 2;
            // 
            // cmbFilterField
            // 
            this.cmbFilterField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterField.FormattingEnabled = true;
            this.cmbFilterField.Items.AddRange(new object[] {
            "年龄",
            "工资"});
            this.cmbFilterField.Location = new System.Drawing.Point(70, 7);
            this.cmbFilterField.Name = "cmbFilterField";
            this.cmbFilterField.Size = new System.Drawing.Size(100, 20);
            this.cmbFilterField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "筛选条件:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(392, 198);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 273);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "数据表格和数据视图示例";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFilterField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbOrderField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}

