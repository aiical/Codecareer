using System;

namespace P6_1
{
    delegate void DualFunction(double x, double y);

    class Program
    {
        static void Main()
        {
            DualFunction fun1;
            double a = 2.5, b = 2;
            Console.Write("请选择函数(加0 减1 乘2 除3)：");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
                fun1 = new DualFunction(Sub);
            else if (i == 2)
                fun1 = new DualFunction(Mul);
            else if (i == 3)
                fun1 = new DualFunction(Div);
            else
                fun1 = new DualFunction(Add);
            fun1(a, b);
            Console.ReadLine();
        }

        static void Add(double x, double y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }

        static void Sub(double x, double y)
        {
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        }

        static void Mul(double x, double y)
        {
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        }

        static void Div(double x, double y)
        {
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        }
    }
}
