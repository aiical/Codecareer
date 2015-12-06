using System;

namespace P14_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = this.Request.QueryString["id"];
            if (id == null)
                Response.Write("错误:未指定学生学号");
            else if (id == "1001")
                Response.Write(new Student("周军", true, new DateTime(1988, 2, 8)));
            else if (id == "1002")
                Response.Write(new Student("刘莉", false, new DateTime(1990, 9, 1)));
            else
                Response.Write("没有找到指定的学生");
        }
    }

    public class Student
    {
        private string name;
        private bool gender;
        private DateTime birthday;

        public Student(string name, bool gender, DateTime birthday)
        {
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
        }

        public override string ToString()
        {
            return string.Format("姓名:{0} 性别:{1} 年龄:{2}", name, gender ? '男' : '女', DateTime.Now.Year - birthday.Year);
        }
    }

}