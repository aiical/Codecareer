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

namespace P16_2
{
    public partial class MainPage : UserControl
    {
        bool mouseMoving = false; 
        Point mousePosition;

        public MainPage()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            button1.Focus();
        }

        void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                double x = Canvas.GetLeft(button1) - 5;
                if (x >= 0)
                    Canvas.SetLeft(button1, x);
            }
            else if (e.Key == Key.Right)
            {
                double x = Canvas.GetLeft(button1) + 5;
                if (x + 80 <= LayoutRoot.ActualWidth)
                    Canvas.SetLeft(button1, x);
            }
            if (e.Key == Key.Up)
            {
                double y = Canvas.GetTop(button1) - 5;
                if (y >= 0)
                    Canvas.SetTop(button1, y);
            }
            else if (e.Key == Key.Down)
            {
                double y = Canvas.GetTop(button1) + 5;
                if (y + 40 <= LayoutRoot.ActualHeight)
                    Canvas.SetTop(button1, y);
            }
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            if(!mouseMoving)
                button1.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!mouseMoving)
                button1.Cursor = Cursors.None;
        }

        private void button1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mouseMoving = true;
            mousePosition = e.GetPosition(null);
            button1.CaptureMouse();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMoving)
            {
                double dx = e.GetPosition(null).X - mousePosition.X;
                double dy = e.GetPosition(null).Y - mousePosition.Y;
                Canvas.SetLeft(button1, dx + (double)Canvas.GetLeft(button1));
                Canvas.SetTop(button1, dy + (double)Canvas.GetTop(button1));
                mousePosition = e.GetPosition(null);
            }
        }

        private void button1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            mouseMoving = false;
            button1.ReleaseMouseCapture();
            mousePosition.X = mousePosition.Y = 0;
        }
    }
}
