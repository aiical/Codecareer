using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace P14_7
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] ss = { "程序设计", "网站开发", "操作系统维护", "数据库管理", "图形图像", "办公应用" };
            HtmlTableCell cell1, cell2;
            HtmlTableRow row1 = new HtmlTableRow();
            HtmlTableRow row2 = new HtmlTableRow();
            BulletedList[] bls = new BulletedList[6];
            for (int i = 0; i < bls.Length; i++)
            {
                bls[i] = new BulletedList();
                foreach (string s in ss)
                    bls[i].Items.Add(s);
                bls[i].BulletStyle = (BulletStyle)i;
                cell1 = new HtmlTableCell();
                cell1.InnerText = bls[i].BulletStyle.ToString();
                row1.Cells.Add(cell1);
                cell2 = new HtmlTableCell();
                cell2.Controls.Add(bls[i]);
                row2.Cells.Add(cell2);
            }
            HtmlTable table1 = new HtmlTable();
            table1.Border = 1;
            table1.Rows.Add(row1);
            table1.Rows.Add(row2);
            this.form1.Controls.Add(table1);
        }
    }
}