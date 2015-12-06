using System;

namespace P10_4
{
    class Program
    {
        static void Main()
        {
            Seaplane plane = new Seaplane();
            IFlyable flyer = plane;
            Console.WriteLine("{0}空中飞行1000公里需{1}小时", flyer, flyer.Run(1000));
            ISwimmable swimmer = plane;
            Console.WriteLine("{0}水上航行1000公里需{1}小时", swimmer, swimmer.Run(1000));
            Amphicar car = new Amphicar(80);
            Console.WriteLine("{0}地面行驶1000公里需{1}小时", car, car.Run(1000));
            swimmer = car;
            Console.WriteLine("{0}水上航行1000公里需{1}小时", swimmer, swimmer.Run(1000));
            Console.ReadLine();
        }
    }

    public interface IFlyable
    {
        float Run(float distance);
    }

    public interface ISwimmable
    {
        float Run(float distance);
    }

    public class Seaplane : IFlyable, ISwimmable
    {
        float ISwimmable.Run(float distance)
        {
            return distance / 50;
        }

        float IFlyable.Run(float distance)
        {
            return distance / 400;
        }
    }

    public class Automobile
    {
        private float speed;
        public float Speed
        {
            get { return speed; }
        }

        public virtual float Run(float distance)
        {
            return distance / speed;
        }

        public Automobile(float speed)
        {
            this.speed = speed;
        }
    }

    public class Amphicar : Automobile, ISwimmable
    {
        public Amphicar(float speed)
            : base(speed)
        { }

        float ISwimmable.Run(float distance)
        {
            return base.Run(distance) * 3;
        }
    }

}
