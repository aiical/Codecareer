using System;

namespace P3_10
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.WriteLine("欢迎光临");
                Console.WriteLine("按Q退出，按其它键继续");
            }
            while (Console.ReadKey().KeyChar != 'Q');
        }
    }
}
