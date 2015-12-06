using System;

namespace P4_3
{
    class Program
    {
        static void Main()
        {
            int a = 10, b = 20;
            ValueSwap(a, b);
            Console.WriteLine("值传递: a = {0}, b = {1}", a, b);
            ReferenceSwap(ref a, ref b);
            Console.WriteLine("引用传递: a = {0}, b = {1}", a, b);
            Console.ReadLine();
        }

        public static void ValueSwap(int x, int y)
        {
            int z = x;
            x = y;
            y = z;
        }

        public static void ReferenceSwap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
    }
}
