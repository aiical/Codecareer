using System;

namespace P3_12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("请输入一个字符串:");
            string s = Console.ReadLine();
            int i = 0;
            foreach (char ch in s)
            {
                if (ch == 'a')
                    i++;
            }
            Console.WriteLine("a共出现{0}次", i);
            Console.ReadLine();
        }
    }
}
