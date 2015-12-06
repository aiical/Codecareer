using System;
using System.Web.UI.HtmlControls;

namespace P14_5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Student[] students = new Student[] {
                new Student("周军", true, new DateTime(1988, 5, 10), "zj@a.edu"),
                new Student("王小红", false, new DateTime(1983,2,8), "wxh@a.edu"),
                new Student("方小白", true,  new DateTime(1985,12,1), "fxb@a.edu"),
                new Student("刘莉", false,  new DateTime(1990,9,15), "lil@a.edu")
            };
            HtmlTable Table1 = new HtmlTable();
            Table1.Border = 1;
            Table1.CellPadding = 4;
            Table1.CellSpacing = 2;
            HtmlTableRow row1 = new HtmlTableRow(); //标题行
            row1.Style["font-weight"] = "bold";
            for (int i = 0; i < 4; i++)
                row1.Cells.Add(new HtmlTableCell());
            row1.Cells[0].InnerText = "姓名";
            row1.Cells[1].InnerText = "性别";
            row1.Cells[2].InnerText = "年龄";
            row1.Cells[3].InnerText = "Email";
            Table1.Rows.Add(row1);
            for (int i = 0; i < students.Length; i++) //各数据行
            {
                row1 = new HtmlTableRow();
                if (i % 2 == 1)
                    row1.Style["background-color"] = "Gray";
                for (int j = 0; j < 4; j++)
                    row1.Cells.Add(new HtmlTableCell());
                row1.Cells[0].InnerText = students[i].Name;
                row1.Cells[1].InnerText = students[i].Gender ? "男" : "女";
                row1.Cells[2].InnerText = students[i].Age.ToString();
                row1.Cells[3].InnerHtml = string.Format("<a href='mailto:{0}'> {0}</a>", students[i].Email);
                Table1.Rows.Add(row1);
            }
            row1 = new HtmlTableRow(); //脚注行
            HtmlTableCell cell1 = new HtmlTableCell();
            cell1.InnerText = "数据采集于2012年12月31日";
            cell1.Style["font-size"] = "small";
            cell1.ColSpan = 4;
            row1.Cells.Add(cell1);
            Table1.Rows.Add(row1);
            this.Controls.Add(Table1);*/
        }
    }

    public class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private bool gender;
        public bool Gender
        {
            get { return gender; }
        }

        private DateTime birthday;
        public int Age
        {
            get { return DateTime.Now.Year - birthday.Year; }
        }

        public string Email { get; set; }

        public Student(string name, bool gender, DateTime birthday, string email)
        {
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
            this.Email = email;
        }
    }
}