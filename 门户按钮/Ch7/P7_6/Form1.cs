using System;
using System.Windows.Forms;

namespace P7_6
{
    public partial class Form1 : Form
    {
        private int totalHours = 0;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            Course[] courses = new Course[7] { new Course("英语", 50), new Course("高等数学", 60), new Course("数理统计", 35), new Course("大学物理", 40), new Course("电子电工", 45), new Course("计算机应用基础", 40), new Course("计算机语言程序设计", 45) };
            for (int i = 0; i < 7; i++)
                comboBox1.Items.Add(courses[i]);
            textBox1.Text = "0";
        }

        void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Course c1 = (Course)comboBox1.SelectedItem;
                if (!listBox1.Items.Contains(c1))
                {
                    listBox1.Items.Add(c1);
                    totalHours += c1.hours;
                    textBox1.Text = totalHours.ToString();
                }
            }
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Course c1 = (Course)listBox1.SelectedItem;
                listBox1.Items.Remove(c1);
                totalHours -= c1.hours;
                textBox1.Text = totalHours.ToString();
            }
        }
    }

    public class Course
    {
        public string name;
        public int hours;

        public Course(string name, int hours)
        {
            this.name = name;
            this.hours = hours;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
