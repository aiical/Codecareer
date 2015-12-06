using System;

namespace P9_5
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine(100 / (10 - ReadRecip()));
            }
            catch (Exception exp)
            {
                WriteExceptionInfo(exp);
            }
        }

        static int ReadRecip()
        {
            return 100 / ReadInt();
        }

        static int ReadInt()
        {
            Console.Write("请输入一个整数:");
            return int.Parse(Console.ReadLine());
        }

        static void WriteExceptionInfo(Exception exp)
        {
            Console.WriteLine("异常类型:{0}", exp.GetType());
            Console.WriteLine("引发程序:{0}", exp.Source);
            Console.WriteLine("引发方法:{0}", exp.TargetSite);
            Console.WriteLine("异常信息:{0}", exp.Message);
            Console.WriteLine("调用堆栈:\n{0}", exp.StackTrace);
        }
    }
}
