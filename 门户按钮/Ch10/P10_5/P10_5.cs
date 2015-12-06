using System;
using System.Collections;

namespace P10_5
{
    class Program
    {
        static void Main()
        {
            ArrayList al1 = new ArrayList();
            al1.Add("王小红");
            al1.Add("周军");
            al1.Insert(0, "方小白");
            al1.Add("Smith");
            al1.Insert(1, "Jerry");
            Console.WriteLine("排序前: ");
            foreach (object obj in al1)
            {
                Console.Write(obj);
                Console.Write(' ');
            }
            al1.Sort();
            Console.WriteLine("\n排序后: ");
            foreach (object obj in al1)
            {
                Console.Write(obj);
                Console.Write(' ');
            }
            Console.ReadLine();
        }
    }
}
