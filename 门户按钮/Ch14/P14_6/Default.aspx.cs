using System;
using System.Text;

namespace P14_6
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RC_Change(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            if (Radio1.Checked)
            {
                if (CheckBox1.Checked)
                    sb1.AppendLine("C# Windows Form程序设计");
                if (CheckBox2.Checked)
                    sb1.AppendLine("ASP .NET 2.0深度解析");
                if (CheckBox3.Checked)
                    sb1.AppendLine("ADO .NET 2.0高级编程");
            }
            else
            {
                if (CheckBox1.Checked)
                    sb1.AppendLine("Windows Forms Programming in VB .NET");
                if (CheckBox2.Checked)
                    sb1.AppendLine("Essential ASP.NET with Examples in VB .NET");
                if (CheckBox3.Checked)
                    sb1.AppendLine("ADO.NET Programming in VB .NET");
            }
            TextArea1.Value = sb1.ToString();
        }
    }
}