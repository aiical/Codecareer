using System;
using System.Windows;
using System.Windows.Controls;

namespace P16_1
{
    public partial class MainPage : UserControl
    {
        System.Windows.Interop.Content content = Application.Current.Host.Content;

        public MainPage()
        {
            InitializeComponent();
            content.Resized += new EventHandler(Content_Resized);
        }

        void Content_Resized(object sender, EventArgs e)
        {
            Canvas.SetLeft(button1, content.ActualWidth - button1.Width);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            content.IsFullScreen = !content.IsFullScreen;
            Canvas.SetLeft(button1, content.ActualWidth - button1.Width);
        }
    }
}
