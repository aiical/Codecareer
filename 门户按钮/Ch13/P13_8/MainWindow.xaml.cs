using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Input;

namespace P13_8
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Line[] lights = new Line[12];
            double x0 = Canvas.GetLeft(ellipse1) + ellipse1.Width / 2;
            double y0 = Canvas.GetTop(ellipse1) + ellipse1.Height / 2;
            double r = ellipse1.Width / 2;
            for (int i = 0, a = 0; i < 12; i++)
            {
                lights[i] = new Line();
                lights[i].X1 = x0 + 1.2 * r * Math.Sin(a * Math.PI / 180);
                lights[i].Y1 = y0 + 1.2 * r * Math.Cos(a * Math.PI / 180);
                lights[i].X2 = x0 + 1.8 * r * Math.Sin(a * Math.PI / 180);
                lights[i].Y2 = y0 + 1.8 * r * Math.Cos(a * Math.PI / 180);
                lights[i].Stroke = Brushes.Red;
                canvas1.Children.Add(lights[i]);
                a += 30;
            }
        }

        private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.P && Keyboard.Modifiers == ModifierKeys.Control)
            {          
                PrintDialog dlg = new PrintDialog();
                if (dlg.ShowDialog() == true)
                    dlg.PrintVisual(canvas1, "WPF打印示例");
            }
        }
    }
}
