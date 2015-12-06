using System;

namespace P14_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Title = "Web应用程序示例";
                this.Response.Write("欢迎光临！");
            }
            else
                this.Response.Write("您的浏览器为: " + this.Request.Browser.Type);

        }
    }
}