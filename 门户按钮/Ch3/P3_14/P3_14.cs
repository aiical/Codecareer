using System;

namespace P3_14
{
    class Program
    {
        static void Main()
        {
            int[] x = { 24, -316, 57, 200, 106, -10, 0, 1000, 99 };
            int j = 0;
            foreach (int i in x)
            {
                if (i > 100)
                {
                    j = i;
                    goto end;
                }
            }
        end: Console.WriteLine("x中第一个大于100的元素为{0}", j);

            /*无goto循环示例1:
            foreach (int i in x)
            {
                if (i > 100)
                {
                    j = i;
                    Console.WriteLine("x中第一个大于100的元素为{0}", j);
                    break;
                }
            }*/

            Console.ReadLine();
        }
    }
}
