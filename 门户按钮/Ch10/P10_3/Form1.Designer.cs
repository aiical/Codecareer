namespace P10_3
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCard = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMoney = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 10F);
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 18);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "POS1(北京)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(162, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 18);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "POS2(上海)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择银行卡:";
            // 
            // cmbCard
            // 
            this.cmbCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCard.FormattingEnabled = true;
            this.cmbCard.Location = new System.Drawing.Point(125, 46);
            this.cmbCard.Name = "cmbCard";
            this.cmbCard.Size = new System.Drawing.Size(150, 21);
            this.cmbCard.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "请选择货币种类:";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(135, 77);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(140, 21);
            this.cmbCurrency.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "请选择付款金额:";
            // 
            // nudMoney
            // 
            this.nudMoney.Location = new System.Drawing.Point(135, 104);
            this.nudMoney.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMoney.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMoney.Name = "nudMoney";
            this.nudMoney.Size = new System.Drawing.Size(140, 23);
            this.nudMoney.TabIndex = 7;
            this.nudMoney.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "付款";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "POS机消费演示";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMoney;
        private System.Windows.Forms.Button button1;
    }
}

