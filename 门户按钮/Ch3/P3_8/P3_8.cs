using System;

namespace P3_8
{
    class Program
    {
        static void Main()
        {
            Console.Write("请输入x的值:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("请输入y的值:");
            int y = int.Parse(Console.ReadLine());
            Console.Write("请输入z的值:");
            int z = int.Parse(Console.ReadLine());
            Console.Write("最大值为: ");
            if (x >= y)
            {
                if (x >= z)
                    Console.WriteLine(x);
                else
                    Console.WriteLine(z);
            }
            else
            {
                if (y >= z)
                    Console.WriteLine(y);
                else
                    Console.WriteLine(z);
            }
            Console.ReadLine();
        }
    }
}
