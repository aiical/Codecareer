using System;

namespace P6_3
{
    class Program
    {
        delegate int OneDelegate(int x);

        static void Main()
        {
            int x = 0;
            OneDelegate dg1 = new OneDelegate(Increment); //封装命名方法
            Console.WriteLine(dg1(x));
            Console.WriteLine(x);
            Console.WriteLine(dg1(x));
            Console.WriteLine(x);
            dg1 = delegate { return ++x; }; //封装匿名方法
            Console.WriteLine(dg1(x));
            Console.WriteLine(x);
            Console.WriteLine(dg1(x));
            Console.WriteLine(x);
            Console.ReadLine();
        }

        public static int Increment(int x)
        {
            return ++x;
        }
    }
}
