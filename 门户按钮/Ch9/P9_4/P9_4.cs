using System;

namespace P9_4
{
    class Program
    {
        static void Main()
        {
            try
            {
                int y = ReadRecip();
                Console.WriteLine(100 / (10 - y));
            }
            catch(Exception exp)
            {
                Console.WriteLine("Main方法中发生异常:{0}", exp.GetType());
            }
        }

        static int ReadRecip()
        {
            try
            {
                int x = ReadInt();
                return 100 / x;
            }
            catch(DivideByZeroException exp)
            {
                Console.WriteLine("ReadRecip方法中发生异常:{0}", exp.GetType());
                return 0;
            }
        }

        static int ReadInt()
        {
            Console.Write("请输入一个整数:");
            return int.Parse(Console.ReadLine());
        }
    }
}
