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
    public class Boat : SpriteControl
    {
        public Boat()
        {
            this.DefaultStyleKey = typeof(Boat);
        }
    }

    public class Cart : SpriteControl
    {
        public Cart()
        {
            this.DefaultStyleKey = typeof(Cart);
        }

        public bool Load(SpriteControl s)
        {
            Rect rect = new Rect(X, Y + this.Height / 2, this.Width * 2 / 3, this.Height);
            rect.Intersect(s.Rect);
            return !rect.IsEmpty;
        }
    }

    public abstract class Sheep : SpriteControl
    {
        public Sheep()
        {
            Width = 50;
            Height = 60;
        }

        public override void Move(Rect border)
        {
            double y = Y + Vy;
            if (y < border.Bottom)
                Y = y;
            else
                Vy = -Vy;
        }
    }

    public class Xiyangyang : Sheep
    {
        public Xiyangyang()
        {
            this.Vy = 3;
            this.DefaultStyleKey = typeof(Xiyangyang);
        }
    }

    public class Meiyangyang : Sheep
    {
        public Meiyangyang()
        {
            this.Vy = 4;
            this.DefaultStyleKey = typeof(Meiyangyang);
        }
    }

    public class Feiyangyang : Sheep
    {
        public Feiyangyang()
        {
            this.Vy = 5;
            this.DefaultStyleKey = typeof(Feiyangyang);
        }
    }

    public class Lanyangyang : Sheep
    {
        public Lanyangyang()
        {
            this.Vy = 6;
            this.DefaultStyleKey = typeof(Lanyangyang);
        }
    }

    public class Nuanyangyang : Sheep
    {
        public Nuanyangyang()
        {
            this.Vy = 7;
            this.DefaultStyleKey = typeof(Nuanyangyang);
        }
    }

    public class Manyangyang : Sheep
    {
        public Manyangyang()
        {
            this.Vy = 2;
            this.DefaultStyleKey = typeof(Manyangyang);
        }
    }

    public class Huitailang : Sheep
    {
        public Huitailang()
        {
            this.Vy = 5;
            this.DefaultStyleKey = typeof(Huitailang);
        }
    }
}
