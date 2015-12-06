using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace P13_1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Cursor[] cursors = { Cursors.Arrow, Cursors.ArrowCD, Cursors.Cross, Cursors.Hand, Cursors.Help, Cursors.IBeam, Cursors.No, Cursors.Pen, Cursors.ScrollAll, Cursors.SizeAll, Cursors.UpArrow, Cursors.Wait };
            for (int i = 0; i < 3; i++)
                grid1.RowDefinitions.Add(new RowDefinition());
            for (int i = 0; i < 4; i++)
                grid1.ColumnDefinitions.Add(new ColumnDefinition());
            Label[] labels = new Label[12];
            for (int i = 0; i < 12; i++)
            {
                labels[i] = new Label();
                labels[i].Content = cursors[i].ToString();
                labels[i].Cursor = cursors[i];
                grid1.Children.Add(labels[i]);
                Grid.SetRow(labels[i], i / 4);
                Grid.SetColumn(labels[i], i % 4);
            }
            /*WrapPanel stackPanel1 = new WrapPanel();
            this.Content = stackPanel1;
            Label[] labels1 = new Label[12];
            for (int i = 0; i < 12; i++)
            {
                labels1[i] = new Label() { BorderThickness = new Thickness(1), BorderBrush = Brushes.Black };
                labels1[i].Content = cursors[i].ToString();
                labels1[i].Cursor = cursors[i];
                stackPanel1.Children.Add(labels1[i]);
            }*/
        }
    }
}
