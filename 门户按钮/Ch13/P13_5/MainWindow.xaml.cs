using System;
using System.Windows;
using System.Windows.Threading;

namespace P13_5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer1 = new DispatcherTimer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = TimeSpan.FromMilliseconds(200);
            timer1.IsEnabled = true;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
                progressBar1.Value = 0;
            else
                progressBar1.Value += 5;
            this.Title = string.Format("当前进度 {0}%", progressBar1.Value);
        }
    }
}
