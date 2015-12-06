using System;

namespace P5_4
{
    class Program
    {
        static void Main()
        {
            foreach (Automobile a in GetAutos())
            {
                a.Speak();
                Console.WriteLine(a.ToString());
                Console.WriteLine("{0}行驶1000公里需{1}小时", a.Name, a.Run(1000));
            }
            Console.ReadLine();
        }

        static Automobile[] GetAutos()
        {
            Automobile[] autos = new Automobile[4];
            autos[0] = new Bus("客车", 20);
            autos[1] = new Truck("东风卡车", 30);
            autos[2] = new Truck("黄河卡车", 45);
            autos[3] = new Automobile("汽车", 80, 3);
            return autos;
        }
    }

    public class Automobile
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private float speed;
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

        public Automobile(string name, float speed, float weight)
        {
            this.name = name;
            this.speed = speed;
            this.weight = weight;
        }

        public virtual float Run(float distance) //虚拟方法
        {
            return distance / speed;
        }

        public virtual void Speak() //虚拟方法
        {
            Console.WriteLine("汽车鸣笛...");
        }

        public override string ToString()
        {
            return name;
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

        public Bus(string name, int passengers)
            : base(name, 60, 10)
        {
            this.passengers = passengers;
        }

        public override void Speak() //重载方法
        {
            Console.WriteLine("嘀...嘀....");
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

        public Truck(string name, int load)
            : base(name, 50, 15)
        {
            this.load = load;
        }

        public override float Run(float distance) //重载方法
        {
            return (1 + load / Weight / 2) * base.Run(distance);
        }

        public override void Speak() //重载方法
        {
            Console.WriteLine("叭...叭...");
        }
    }
}
