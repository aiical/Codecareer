using System;

namespace P5_5
{
    class Program
    {
        static void Main()
        {
            Vehicle v1 = new Train();
            v1.Speak();
            Console.WriteLine("行驶1000公里需{0}小时", v1.Run(1000));
            v1 = new Truck(16, 24);
            v1.Speak();
            Console.WriteLine("行驶1000公里需{0}小时", v1.Run(1000));
            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        private float speed;
        public float Speed
        {
            get { return speed; }
        }

        public Vehicle(float speed)
        {
            this.speed = speed;
        }

        public virtual float Run(float distance) //虚拟方法
        {
            return distance / speed;
        }

        public abstract void Speak(); //抽象方法：无执行代码
    }

    public class Train : Vehicle
    {
        public Train()
            : base(160)
        { }

        public override void Speak() //重载
        {
            Console.WriteLine("呜......");
        }
    }

    public abstract class Automobile : Vehicle
    {
        public Automobile(float speed)
            : base(speed)
        { }

        public override abstract void Speak(); //重载+抽象
    }

    public class Truck : Automobile
    {
        private float weight;
        public float Weight
        {
            get { return weight; }
        }

        private float load;
        public float Load
        {
            get { return load; }
        }

        public Truck(int weight, int load)
            : base(50)
        {
            this.weight = weight;
            this.load = load;
        }

        public override float Run(float distance) //重载
        {
            return (1 + load / Weight / 2) * base.Run(distance);
        }

        public override void Speak() //重载
        {
            Console.WriteLine("叭...叭...");
        }
    }
}
