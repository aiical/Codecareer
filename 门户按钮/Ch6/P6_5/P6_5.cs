using System;

namespace P6_5
{
    class Program
    {
        static void Main()
        {
            TrafficLight light = new TrafficLight();
            Car car1 = new Car();
            car1.Enter(light);
            light.ChangeColor(60);
            light.ChangeColor(30);
            Console.ReadLine();
        }
    }

    public class LightEventArgs : EventArgs
    {
        private int seconds;
        public int Seconds
        {
            get { return seconds; }
        }

        public LightEventArgs(int seconds)
        {
            this.seconds = seconds;
        }
    }

    public class TrafficLight
    {
        private bool color = false;
        public bool Color
        {
            get { return color; }
        }

        public event EventHandler OnColorChange; //事件发布

        public void ChangeColor(int seconds)
        {
            color = !color;
            Console.WriteLine(color ? "红灯亮" : "绿灯亮");
            if (OnColorChange != null)
                OnColorChange(this, new LightEventArgs(seconds));
        }
    }

    public class Car
    {
        private bool bRun = true;

        public void Enter(TrafficLight light)
        {
            light.OnColorChange += delegate(object sender, EventArgs e)
            {
                if (light.Color)
                {
                    bRun = false;
                    Console.WriteLine("{0}停车, {1}秒后启动", this, ((LightEventArgs)e).Seconds);
                }
                else
                {
                    bRun = true;
                    Console.WriteLine("{0}启动, {1}秒内通过", this, ((LightEventArgs)e).Seconds);
                }
            };
        }
    }
}
