using System;

namespace P3_13
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("欢迎光临");
                Console.WriteLine("按Q退出，按其它键继续");
                if (Console.ReadKey().KeyChar == 'Q')
                    break; //跳出while循环
            }
        }
    }
}
