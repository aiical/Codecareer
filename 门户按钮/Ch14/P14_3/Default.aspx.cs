using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace P14_3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(80, 40);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 0, 0, 79, 39); //绘制边框
            Color[] colors = { Color.Black, Color.Red, Color.Blue, Color.DarkGreen, Color.Purple, Color.DarkGoldenrod, Color.Chocolate };
            string[] fonts = { "宋体", "楷体_GB2312", "隶书", "Arial", "Comic Sans MS", "Microsoft Sans Serif", "Times New Roman" };
            Random rand = new Random();
            char[] chs = new char[] { (char)(65 + rand.Next(26)), (char)(65 + rand.Next(26)), (char)(65 + rand.Next(26)) }; //随机生成验证字符
            int x, y;
            for (int i = 0; i < 3; i++) //用随机字体和颜色绘制验证码
            {
                Brush brush = new SolidBrush(colors[rand.Next(7)]);
                Font font = new Font(fonts[rand.Next(7)], 18, FontStyle.Bold);
                x = i * 20 + 2;
                y = 5 + rand.Next(5);
                g.RotateTransform(rand.Next(-10, 9));
                g.DrawString(chs[i].ToString(), font, brush, x, y);
            }
            Pen[] pens = { Pens.Gray, Pens.LightGray };
            for (int i = 0; i < 200; i++) //绘制随机噪点 
            {
                x = rand.Next(bmp.Width - 1);
                y = rand.Next(bmp.Height - 1);
                g.DrawEllipse(pens[i % 2], x, y, 1, 1);
            }
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
            this.Response.Clear();
            this.Response.ContentType = "image/Jpeg";
            this.Response.BinaryWrite(ms.ToArray()); //输出图像
            g.Dispose();
            bmp.Dispose();
        }
    }
}