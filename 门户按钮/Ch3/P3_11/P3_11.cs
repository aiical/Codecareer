using System;

namespace P3_11
{
    class Program
    {
        static void Main()
        {
            int[,] x = new int[9, 9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    x[i, j] = (i + 1) * (j + 1);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(x[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
