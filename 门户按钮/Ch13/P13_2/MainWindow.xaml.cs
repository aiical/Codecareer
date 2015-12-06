using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace P13_2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid1 = new Grid() { Name = "Grid" };
            StackPanel stackPanel1 = new StackPanel() { Name = "StackPanel" };
            WrapPanel wrapPanel1 = new WrapPanel() { Name = "WrapPanel" };
            DockPanel dockPanel1 = new DockPanel() { Name = "DockPanel" };
            Panel[] panels = { grid1, stackPanel1, wrapPanel1, dockPanel1 };
            TabControl tabControl1 = new TabControl();
            this.Content = tabControl1;
            for (int i = 0; i < panels.Length; i++)
                tabControl1.Items.Add(new TabItem() { Header = panels[i].Name, Content = panels[i] });
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
            grid1.ShowGridLines = true;
            Label[] labels1 = new Label[12];
            for (int i = 0; i < 12; i++)
            {
                labels1[i] = new Label();
                labels1[i].Content = cursors[i].ToString();
                labels1[i].Cursor = cursors[i];
                labels1[i].BorderThickness = new Thickness(1);
                labels1[i].BorderBrush = Brushes.Black;
                stackPanel1.Children.Add(labels1[i]);
            }
            Label[] labels2 = new Label[12];
            for (int i = 0; i < 12; i++)
            {
                labels2[i] = new Label();
                labels2[i].Content = cursors[i].ToString();
                labels2[i].Cursor = cursors[i];
                labels2[i].BorderThickness = new Thickness(1);
                labels2[i].BorderBrush = Brushes.Black;
                wrapPanel1.Children.Add(labels2[i]);
            }
            Label[] labels3 = new Label[12];
            for (int i = 0; i < 12; i++)
            {
                labels3[i] = new Label();
                labels3[i].Content = cursors[i].ToString();
                labels3[i].Cursor = cursors[i];
                labels3[i].BorderThickness = new Thickness(1);
                labels3[i].BorderBrush = Brushes.Black;
                dockPanel1.Children.Add(labels3[i]);
                DockPanel.SetDock(labels3[i], (i % 2 == 0) ? Dock.Left : Dock.Top);
            }
        }
    }
}
