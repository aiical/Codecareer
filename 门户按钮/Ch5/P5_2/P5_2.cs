using System;

namespace P5_2
{
    class Program
    {
        static void Main()
        {
            Truck t1 = new Truck();
            Console.WriteLine("卡车速度{0}公里/小时", t1.Speed);
            Console.WriteLine("卡车行驶1000公里需{0}小时", t1.Run(1000));
            Automobile a1 = t1;
            Console.WriteLine("汽车速度{0}公里/小时", a1.Speed);
            Console.WriteLine("汽车行驶1000公里需{0}小时", a1.Run(1000));
            Console.ReadLine();
        }
    }

    public class Automobile
    {
        protected float speed;
        public float Speed
        {
            get { return speed; }
        }

        private float weight;
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public float Run(float distance)
        {
            return distance / speed;
        }
    }

    public class Truck : Automobile
    {
        private float load;
        public float Load
        {
            get { return load; }
            set { load = value; }
        }

        public new float Speed
        {
            get { return speed / (1 + load / Weight / 2); }
        }

        public Truck()
        {
            load = 30;
            speed = 50;
            Weight = 15;
        }

        public new float Run(float distance)
        {
            return (1 + load / Weight / 2) * base.Run(distance);
        }
    }
}
