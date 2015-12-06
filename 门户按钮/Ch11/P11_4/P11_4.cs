using System;

namespace P11_4
{
    class Program
    {
        static void Main()
        {
            GA<int> g1 = new GA<int>();
            GA<string> g2 = new GA<string>();
            GA<int> g3 = new GA<int>();
            g1 = new GA<int>();
            g2 = new GA<string>();
            Console.ReadLine();
        }
    }

    public class GA<T>
    {
        T t = default(T);
        static int objects = 0;
        static int classes = 0;

        public GA() //实例构造函数
        {
            Console.WriteLine("GA<{0}>对象计数: {1}", typeof(T), ++objects);
        }

        static GA() //静态构造函数
        {
            Console.WriteLine("GA<{0}>类计数: {1}", typeof(T), ++classes);
        }
    }
}
