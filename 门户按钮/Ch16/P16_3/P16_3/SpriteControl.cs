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

namespace P16_3
{
    public class SpriteControl : Control
    {
        public SpriteControl()
        {
            this.DefaultStyleKey = typeof(SpriteControl);
        }

        public double X
        {
            get { return Canvas.GetLeft(this); }
            set { Canvas.SetLeft(this, value); }
        }
        public double Y
        {
            get { return Canvas.GetTop(this); }
            set { Canvas.SetTop(this, value); }
        }
        public virtual Rect Rect
        {
            get { return new Rect(X, Y, this.Width, this.Height); }
        }

        public double Vx { get; set; }
        public double Vy { get; set; }

        public virtual void Move(Rect border)
        {
            double x = X + Vx;
            if (x >= border.Left && x + this.Width <= border.Right)
                X = x;
            else
                Vx = -Vx;
            double y = Y + Vy;
            if (y >= border.Top && x + this.Height <= border.Bottom)
                Y = y;
            else
                Vy = -Vy;
        }

        public virtual bool Intersect(SpriteControl s)
        {
            Rect rect = this.Rect;
            rect.Intersect(s.Rect);
            return !rect.IsEmpty;
        }
    }
}
