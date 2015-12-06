using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace P16_3
{
    public partial class MainPage : UserControl
    {
        DispatcherTimer timer;
        Rect border;
        int score = 100, maxScore = 500;
        Random rand = new Random();
        List<Sheep> sheeps = new List<Sheep>();

        public MainPage()
        {
            InitializeComponent();
            boat.Vx = 2;
            border = new Rect(0, 0, canvas1.ActualWidth, canvas1.ActualHeight);
            timer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(40) };
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            border = new Rect(0, 0, canvas1.ActualWidth, canvas1.ActualHeight);
            Canvas.SetTop(cart, canvas1.ActualHeight - 100);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Application.Current.RootVisual.KeyDown += new KeyEventHandler(RootVisual_KeyDown);
            Application.Current.RootVisual.KeyUp += new KeyEventHandler(RootVisual_KeyUp);
        }

        void RootVisual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
                cart.Vx = -5;
            else if (e.Key == Key.Right)
                cart.Vx = 5;
        }

        void RootVisual_KeyUp(object sender, KeyEventArgs e)
        {
            cart.Vx = 0;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Sheep sheep = null;
            int r = rand.Next(200);
            if (r == 0)
                sheep = new Xiyangyang();
            else if (r == 1)
                sheep = new Meiyangyang();
            else if (r == 2)
                sheep = new Feiyangyang();
            else if (r == 3)
                sheep = new Lanyangyang();
            else if (r == 4)
                sheep = new Nuanyangyang();
            else if (r == 5)
                sheep = new Manyangyang();
            else if (r == 6)
                sheep = new Huitailang();
            if (sheep != null)
            {
                sheeps.Add(sheep);
                Canvas.SetLeft(sheep, boat.X + 20);
                Canvas.SetTop(sheep, boat.Y + 30);
                canvas1.Children.Add(sheep);
            }
            for (int i = sheeps.Count - 1; i >= 0; i--)
            {
                if (cart.Load(sheeps[i]))
                {
                    if (!(sheeps[i] is Huitailang))
                    {
                        score += 20;
                        if (score >= maxScore)
                        {
                            StopGame();
                            return;
                        }
                    }
                    else
                    {
                        score -= 50;
                        if (score <= 0)
                        {
                            StopGame();
                            return;
                        }
                    }
                    tbScore.Text = string.Format("得分{0}", score);
                    canvas1.Children.Remove(sheeps[i]);
                    sheeps.RemoveAt(i);
                }
                else if (sheeps[i].Vy < 0)
                {
                    score -= 20;
                    if (score <= 0)
                    {
                        StopGame();
                        return;
                    }
                    tbScore.Text = string.Format("得分{0}", score);
                    canvas1.Children.Remove(sheeps[i]);
                    sheeps.RemoveAt(i);
                }
                else
                    sheeps[i].Move(border);
            }
            boat.Move(border);
            if (cart.Vx != 0)
                cart.Move(border);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
                btn1.Content = "开始";
            }
            else
            {
                timer.Start();
                btn1.Content = "暂停";
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Host.Content.IsFullScreen = !Application.Current.Host.Content.IsFullScreen;
        }

        public void StopGame()
        {
            timer.Stop();
            btn1.IsEnabled = btn2.IsEnabled = false;
            sheeps.Clear();
            tbScore.Text = (score <= 0) ? "游戏失败" : "成功过关";
        }
    }
}
