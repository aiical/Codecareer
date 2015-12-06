namespace P8_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudGrade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSupervisor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号:";
            // 
            // cmbID
            // 
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(60, 7);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(121, 21);
            this.cmbID.TabIndex = 1;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(60, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 23);
            this.tbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别:";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(60, 67);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(123, 23);
            this.tbDepartment.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "院系:";
            // 
            // nudGrade
            // 
            this.nudGrade.Location = new System.Drawing.Point(250, 67);
            this.nudGrade.Name = "nudGrade";
            this.nudGrade.Size = new System.Drawing.Size(60, 23);
            this.nudGrade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "年级:";
            // 
            // tbSupervisor
            // 
            this.tbSupervisor.Location = new System.Drawing.Point(60, 97);
            this.tbSupervisor.Name = "tbSupervisor";
            this.tbSupervisor.Size = new System.Drawing.Size(123, 23);
            this.tbSupervisor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "导师:";
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Checked = true;
            this.rdbMan.Location = new System.Drawing.Point(250, 37);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(39, 18);
            this.rdbMan.TabIndex = 11;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "男";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(295, 37);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(39, 18);
            this.rdbWoman.TabIndex = 12;
            this.rdbWoman.Text = "女";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(10, 140);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(60, 23);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "修改";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(94, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 183);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.rdbWoman);
            this.Controls.Add(this.rdbMan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSupervisor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "学生信息窗体";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSupervisor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
    }
}

