using System;

namespace P14_8
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["fid"] == null)
                Application["fid"] = 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!FileUpload1.HasFile)
                Label1.Text = "请选择要上传的文件!";
            else if (FileUpload1.PostedFile.ContentType != "application/msword")
                Label1.Text = "文件类型必须为doc!";
            else if (FileUpload1.PostedFile.ContentLength > 1048576)
                Label1.Text = "文件大小不能超过1M!";
            else
            {
                try
                {
                    int id = (int)Application["fid"];
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Files/") + id + ".doc");
                    Application["fid"] = id + 1;
                    Label1.Text = "成功上传文件" + FileUpload1.FileName;
                }
                catch (Exception exp)
                {
                    Label1.Text = "上传失败:" + exp.ToString();
                }
            }
        }
    }
}