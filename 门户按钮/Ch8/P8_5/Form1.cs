using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace P8_5
{
    public partial class Form1 : Form
    {
        Student[] students;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new Student[5];
            FileStream fs1 = new FileStream("students.bin", FileMode.Open);
            BinaryFormatter bf1 = new BinaryFormatter();
            //FileStream fs1 = new FileStream("students.xml", FileMode.Open);
            //SoapFormatter bf1 = new SoapFormatter();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = (Student)bf1.Deserialize(fs1);
                cmbID.Items.Add(students[i].ID);
            }
            fs1.Close();
            cmbID.SelectedIndex = 0;
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student s1 = students[cmbID.SelectedIndex];
            tbName.Text = s1.Name;
            if (s1.Gender)
                rdbMan.Checked = true;
            else
                rdbWoman.Checked = true;
            tbDepartment.Text = s1.Department;
            nudGrade.Value = s1.Grade;
            if (s1 is Graduate)
            {
                tbSupervisor.Enabled = true;
                tbSupervisor.Text = ((Graduate)s1).Supervisor;
            }
            else
            {
                tbSupervisor.Text = "";
                tbSupervisor.Enabled = false;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Student s1 = students[cmbID.SelectedIndex];
            s1.Name= tbName.Text;
            s1.Gender = rdbMan.Checked;
            s1.Department = tbDepartment.Text;
            s1.Grade = (byte)nudGrade.Value;
            if (s1 is Graduate)
                ((Graduate)s1).Supervisor = tbSupervisor.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream("students.bin", FileMode.OpenOrCreate);
            BinaryFormatter bf1 = new BinaryFormatter();
            //FileStream fs1 = new FileStream("students.xml", FileMode.OpenOrCreate);
            //SoapFormatter bf1 = new SoapFormatter();
            foreach (Student s in students)
                bf1.Serialize(fs1, s);
            fs1.Close();
            MessageBox.Show("保存成功!");
        }
    }
}
