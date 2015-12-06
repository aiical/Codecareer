using System;
using System.IO;

namespace P8_2
{
    class P8_2
    {
        static void Main()
        {
            FileStream fs1 = new FileStream("num.txt", FileMode.Create);
            for (ushort a = 1, b = 1; a <= 10000; a += b)
            {
                ushort t = b;
                b = a;
                a = t;
                fs1.WriteByte((byte)(a / 256)); //写入前8位
                fs1.WriteByte((byte)(a % 256)); //写入后8位
            }
            fs1.Position = 0;
            Console.Write("请输入要读取的数列项: ");
            int i = int.Parse(Console.ReadLine());
            fs1.Position = 2 * i;
            int x = 256 * fs1.ReadByte() + fs1.ReadByte();
            Console.WriteLine("数列项为: " + x);
            fs1.Close();
            Console.ReadLine();
        }
    }
}
