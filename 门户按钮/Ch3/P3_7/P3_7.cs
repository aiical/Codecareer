using System;

namespace P3_7
{
    class Program
    {
        static void Main()
        {
            bool[] x = new bool[5];
            Console.WriteLine("请依次输入5位考官的评分，1通过，0不通过: ");
            x[0] = (Console.ReadLine() == "1");
            x[1] = (Console.ReadLine() == "1");
            x[2] = (Console.ReadLine() == "1");
            x[3] = (Console.ReadLine() == "1");
            x[4] = (Console.ReadLine() == "1");
            int i = 0;
            bool b = (x[i++]) && (x[i++] || x[i]) && (x[++i] || x[++i]);
            Console.WriteLine("考核结果为: {0}", b);
            Console.WriteLine("判断次数为: {0}", i); 
            Console.ReadLine();
        }
    }

    enum Weekday
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

}
