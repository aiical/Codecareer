using System;

namespace P14_4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ViewState["iRows"] = 1;
            string[] seasons = { "立春", "雨水", "惊蛰", "春分", "清明", "谷雨", "立夏", "小满", "芒种", "夏至", "小暑", "大暑", "立秋", "处暑", "白露", "秋分", "寒露", "霜降", "立冬", "小雪", "大雪", "冬至", "小寒", "大寒" };
            int iRows = (int)ViewState["iRows"];
            for (int i = 0; i < iRows; i++)
            {
                for (int j = 0; j < 24 / iRows; j++)
                    Response.Write(seasons[i * iRows + j] + ' ');
                Response.Write("<br/>");
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            int iRows = (int)ViewState["iRows"];
            if (iRows < 4)
                ViewState["iRows"] = iRows + 1;
        }
    }
}