using System;

namespace P4_4
{
    class Program
    {
        static void Main(params string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("未指定输入参数");
                return;
            }
            double s = double.Parse(args[1]);
            if (args[0] == "SUM")
            {
                for (int i = 2; i < args.Length; i++)
                    s += double.Parse(args[i]);
            }
            else if (args[0] == "PROD")
            {
                for (int i = 2; i < args.Length; i++)
                    s *= double.Parse(args[i]);
            }
            Console.WriteLine(s);
        }
    }

}
