using System;

namespace P6_4
{
    class Program
    {
        static void Main()
        {
            TrafficLight light = new TrafficLight();
            Car car1 = new Car();
            car1.Enter(light);
            Ambulance amb1 = new Ambulance();
            amb1.Enter(light);
            light.ChangeColor();
            light.ChangeColor();
            amb1.Emergent = true;
            light.ChangeColor();
            Console.ReadLine();
        }
    }

    public delegate void LightEvent(bool color);

    public class TrafficLight
    {
        private bool color = false;
        public bool Color
        {
            get { return color; }
        }

        public event LightEvent OnColorChange; //事件发布

        public void ChangeColor()
        {
            color = !color;
            Console.WriteLine(color ? "红灯亮" : "绿灯亮");
            if (OnColorChange != null)
                OnColorChange(color);
        }
    }

    public class Car
    {
        private bool bRun = true;

        public void Enter(TrafficLight light)
        {
            light.OnColorChange += LightColorChange; //事件订阅
        }

        public void Leave(TrafficLight light)
        {
            light.OnColorChange -= LightColorChange; //取消事件订阅
        }

        public virtual void LightColorChange(bool color)
        {
            if (bRun && color)
            {
                bRun = false;
                Console.WriteLine("{0}停车", this);
            }
            else if (!bRun && !color)
            {
                bRun = true;
                Console.WriteLine("{0}启动", this);
            }
        }
    }

    public class Ambulance : Car
    {
        private bool emergent = false;
        public bool Emergent
        {
            get { return emergent; }
            set { emergent = value; }
        }

        public override void LightColorChange(bool color)
        {
            if (emergent)
                Console.WriteLine("{0}紧急行驶", this);
            else
                base.LightColorChange(color);
        }
    }
}
