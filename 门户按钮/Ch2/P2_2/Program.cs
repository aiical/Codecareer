using System;

namespace P2_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("请输入姓名:");
            string name = Console.ReadLine();
            Console.Write(name);
            Console.Write(",");
            P2_1.Program.Main();
            Console.WriteLine();
        }
    }
}
