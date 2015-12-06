using System;

namespace P3_4
{
    class Program
    {
        static void Main()
        {
            int[,] x = new int[2, 3] { { 1, 2, 3 }, { 3, 5, 8 } };
            int[,] y = new int[,] { { 10, 50 }, { 25, 75 }, { 50, 150 }, { 100, 80 } };
            int[, ,] z = { { { 1, 2 }, { 3, 5 }, { 8, 13 } }, { { 1, 2 }, { 3, 5 }, { 8, 13 } } };
            Console.Write("数组x长度为: ");
            Console.WriteLine(x.Length);
            Console.WriteLine("各维长度: {0} * {1}", x.GetLength(0), x.GetLength(1));
            Console.Write("数组y长度为: ");
            Console.WriteLine(y.Length);
            Console.WriteLine("各维长度: {0} * {1}", y.GetLength(0), y.GetLength(1));
            Console.Write("数组z长度为: ");
            Console.WriteLine(z.Length);
            Console.WriteLine("各维长度: {0} * {1} * {2}", z.GetLength(0), z.GetLength(1), z.GetLength(2));
            Console.ReadLine();
        }
    }
}
