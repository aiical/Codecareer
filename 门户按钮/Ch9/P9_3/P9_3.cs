using System;

namespace P9_3
{
    class Program
    {
        static void Main()
        {
            int m = -1, n = 0;
            double sum = 0;
            Console.WriteLine("请依次输入一组数值，输入END结束:");
            while (true)
            {
                try
                {
                    string s = Console.ReadLine();
                    if (s == "" || s.ToUpper() == "END")
                        break;
                    sum += double.Parse(s);
                    n++;
                }
                catch (FormatException)
                {
                    Console.Write("输入的格式不正确，请重新输入:");
                }
                finally
                {
                    m++;                    
                }
            }
            Console.WriteLine("您总共输入了{0}次，其中正确输入{1}次", m, n);
            Console.WriteLine("数组之和为{0}，平均值为{1}", sum, sum / n);
        }
    }
}
