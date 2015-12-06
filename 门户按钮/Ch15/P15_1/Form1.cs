using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace P15_1
{
    public partial class Form1 : Form
    {
        private DataView dataView;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataView = new DataView(this.GetDataTable());
            dataGridView1.DataSource = dataView;
            cmbFilterField.SelectedIndex = cmbOperator.SelectedIndex = cmbOrderField.SelectedIndex = 0;
            dataGridView1.AutoResizeColumns();
            this.Height = 250;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder(cmbFilterField.Text);
            if (cmbOperator.SelectedIndex == 0)
                sb1.Append(">");
            else if (cmbOperator.SelectedIndex == 1)
                sb1.Append("=");
            else
                sb1.Append("<");
            sb1.Append(numericUpDown1.Value);
            dataView.RowFilter = sb1.ToString();
            dataView.Sort = cmbOrderField.Text;
        }

        public DataTable GetDataTable()
        {
            DataTable table1 = new DataTable("Staff");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("姓名", typeof(string));
            table1.Columns.Add("性别", typeof(bool));
            table1.Columns.Add("年龄", typeof(byte));
            table1.Columns.Add("工资", typeof(decimal));
            table1.PrimaryKey = new DataColumn[] { table1.Columns[0] };
            table1.Columns[1].AllowDBNull = false;
            table1.Columns[2].AllowDBNull = false;
            table1.Rows.Add(1, "程学兵", true, 37, 3500);
            table1.Rows.Add(2, "张文强", true, 29, 2500);
            table1.Rows.Add(3, "马秋萍", false, 30, 3000);
            table1.Rows.Add(4, "何艳", false, 24, 1800);
            table1.Rows.Add(5, "薛冰", false, 26, 2400);
            return table1;
        }
    }
}
