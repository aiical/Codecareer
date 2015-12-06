using System;

namespace P9_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("请输入x的值:");
            int x, y = 0;
            try
            {
                x = int.Parse(Console.ReadLine());
                y = 100 / (10 - x) / (x - 5) / x;
            }
            catch
            {
                Console.WriteLine("输入不正确");
            }
            Console.WriteLine("y = {0}", y);
        }
    }
}
