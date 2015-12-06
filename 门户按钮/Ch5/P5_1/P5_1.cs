using System;

namespace P5_1
{
    class Program
    {
        public static void Main()
        {
            Bus b1 = new Bus();
            Console.WriteLine("客车行驶1000公里需{0}小时", b1.Run(1000));
            Truck t1 = new Truck();
            Console.WriteLine("卡车行驶1000公里需{0}小时", t1.Run(1000));
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

    public class Bus : Automobile
    {
        private int passengers;
        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }

        public Bus()
        {
            passengers = 20;
            speed = 60;
            Weight = 10;
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

        public Truck()
        {
            load = 30;
            speed = 50;
            Weight = 15;
        }
    }
}
