using System;

namespace P5_3
{
    class Program
    {
        public static void Main()
        {
            Son s1 = new Son();
            System.GC.Collect();
        }
    }

    public class Grandsire
    {
        public Grandsire()
        {
            Console.WriteLine("调用Grandsire的构造函数");
        }

        ~Grandsire()
        {
            Console.WriteLine("调用Grandsire的析构函数");
        }
    }

    public class Father : Grandsire
    {
        public Father()
        {
            Console.WriteLine("调用Father的构造函数");
        }

        ~Father()
        {
            Console.WriteLine("调用Father的析构函数");
        }
    }

    public class Son : Father
    {
        public Son()
        {
            Console.WriteLine("调用Son的构造函数");
        }

        ~Son()
        {
            Console.WriteLine("调用Son的析构函数");
        }
    }
}
