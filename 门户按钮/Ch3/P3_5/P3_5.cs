using System;

namespace P3_5
{
    class Program
    {
        static void Main()
        {
            Weekday w1 = 0;
            Weekday w2 = (Weekday)3; // 显式转换
            Weekday w3 = (Weekday)100; // 显式转换
            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w3);
            int x = (int)Weekday.Friday; // 显式转换
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }

    enum Weekday
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
