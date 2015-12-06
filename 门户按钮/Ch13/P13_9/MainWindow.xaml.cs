using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace P13_9
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*DoubleAnimation ani1 = new DoubleAnimation() { From = 0, To = 270 };
            DoubleAnimation ani2 = new DoubleAnimation() { From = 0, To =  120};
            ani1.Duration = ani2.Duration = TimeSpan.FromSeconds(2);
            ani1.AutoReverse = ani2.AutoReverse = true;
            ani1.RepeatBehavior = ani2.RepeatBehavior = RepeatBehavior.Forever;
            Storyboard sb = new Storyboard();
            sb.Children.Add(ani1);
            sb.Children.Add(ani2);
            Storyboard.SetTarget(ani1, ball);
            Storyboard.SetTargetProperty(ani1, new PropertyPath(Canvas.LeftProperty));
            Storyboard.SetTarget(ani2, ball);
            Storyboard.SetTargetProperty(ani2, new PropertyPath(Canvas.TopProperty));
            sb.Begin();*/
        }
    }
}
