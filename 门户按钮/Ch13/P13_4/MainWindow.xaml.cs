using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace P13_4
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*RichTextBox rtb = new RichTextBox();
            rtb.Document = new FlowDocument();
            Paragraph p1 = new Paragraph(new Run("语言")) { FontSize = 18 };
            rtb.Document.Blocks.Add(p1);
            string[] lans = { "C#", "C++", "VB", "Java", "Perl" };
            List l1 = new List();
            foreach (string s in lans)
                l1.ListItems.Add(new ListItem(new Paragraph(new Run(s))));
            rtb.Document.Blocks.Add(l1);
            Paragraph p2 = new Paragraph(new Run("课程")) { FontSize = 18 };
            rtb.Document.Blocks.Add(p2);
            string[] cources = { "程序设计基础", "面向对象", "数据库应用", "Web应用" };
            List l2 = new List() { MarkerStyle = TextMarkerStyle.Decimal };
            foreach (string s in cources)
                l2.ListItems.Add(new ListItem(new Paragraph(new Run(s))));
            rtb.Document.Blocks.Add(l2);
            ScrollViewer sView = new ScrollViewer();
            sView.Content = rtb;
            this.Content = sView;*/
        }
    }
}
