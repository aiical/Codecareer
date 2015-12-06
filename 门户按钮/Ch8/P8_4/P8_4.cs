using System;
using System.IO;

namespace P8_4
{
    class P8_4
    {
        static void Main()
        {
            FileStream fs1 = new FileStream("Test.txt", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bw1 = new BinaryWriter(fs1);
            for (byte i = 65; i < 72; i++)
                bw1.Write(i);
            bw1.Write(10);
            for (byte i = 72; i < 79; i++)
                bw1.Write(i);
            bw1.Flush();
            fs1.Position = 0;
            char[] chs = new char[3];
            StreamReader sr1 = new StreamReader(fs1);
            sr1.Read(chs, 0, 3);
            Console.WriteLine(new string(chs)); //输出"ABC"
            Console.WriteLine(sr1.ReadLine()); //输出"DEFG"
            Console.WriteLine(sr1.ReadToEnd()); //输出" HIJKLMN"
            bw1.Close();
            sr1.Close();
            fs1.Close();
            Console.ReadLine();
        }
    }
}
