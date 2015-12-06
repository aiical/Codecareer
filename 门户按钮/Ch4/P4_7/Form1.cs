using System;
using System.Windows.Forms;

namespace P4_7
{
    public partial class Form1 : Form
    {
        protected static string[] errorWords = new string[] {
            "哀声叹气", "重山峻岭", "大才小用", "甘败下风", "留芳百世" ,"美仑美奂",
            "迫不急待", "人情事故", "食不裹腹", "谈笑风声", "一愁莫展", "再接再励" 
        };

        protected static string[] rightWords = new string[] {
            "唉声叹气", "崇山峻岭", "大材小用", "甘拜下风", "流芳百世" ,"美轮美奂",
            "迫不及待", "人情世故", "食不果腹", "谈笑风生", "一筹莫展", "再接再厉" 
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "这种大才小用的人情事故令人一愁莫展，不禁哀声叹气。人们迫不急待地想要改变这一现状。";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < errorWords.Length; i++)
                textBox1.Text = textBox1.Text.Replace(errorWords[i], rightWords[i]);
        }
    }
}
