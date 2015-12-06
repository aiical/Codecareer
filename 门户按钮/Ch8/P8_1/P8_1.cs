using System;
using System.IO;

namespace P8_1
{
    class P8_1
    {
        static void Main()
        {
            if (!File.Exists("a.txt"))
                File.Create("a.txt");
            string[] ss = { "2008-9-30 8:30am 中山路32号", "2009-2-9 2:00pm 华山路1号"};
            File.WriteAllLines("a.txt", ss);
            TypeFile("a.txt");
            EncryptFile("a.txt", "b.txt");
            TypeFile("b.txt");
            EncryptFile("b.txt", "c.txt");
            TypeFile("c.txt");
            Console.ReadLine();
        }

        static void TypeFile(string filename)
        {
            Console.WriteLine(filename);
            foreach (string s in File.ReadAllLines(filename))
                Console.WriteLine(s);
            Console.WriteLine();
        }

        static void EncryptFile(string sourceFile, string targetFile)
        {
            byte[] bs = File.ReadAllBytes(sourceFile);
            for (int i = 0; i < bs.Length; i++)
                bs[i] ^= 7;
            File.WriteAllBytes(targetFile, bs);
        }
    }
}
