using System;

namespace P9_2
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
            catch (FormatException)
            {
                Console.WriteLine("输入的格式不正确，应输入一个整数");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("错误：除数为0");
            }
            catch (Exception)
            {
                Console.WriteLine("程序发生意外错误");
            }
            Console.WriteLine("y = {0}", y);
        }
    }
}
