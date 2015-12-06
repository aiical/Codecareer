using System;

namespace P3_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("按Q退出，按其它键继续");
            while (Console.ReadKey().KeyChar != 'Q')
            {
                Console.WriteLine("欢迎光临");
                Console.WriteLine("按Q退出，按其它键继续");
            }
        }
    }
}
