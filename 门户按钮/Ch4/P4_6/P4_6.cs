using System;
using System.Collections.Generic;
using System.Text;

namespace P4_6
{
    class Program
    {
        static void Main()
        {
            for (uint i = 50; i <= 100; i++)
            {
                Prime p1 = new Prime(i);
                if (p1)
                    Console.WriteLine((uint)i);
            }
            Console.ReadLine();
        }
    }

    public class Prime
    {
        public uint x;

        public Prime(uint x1)
        {
            x = x1;
        }

        public static explicit operator uint(Prime p)
        {
            return p.x;
        }

        public static bool operator true(Prime p)
        {
            for (uint i = 2; i <= p.x / 2; i++)
                if (p.x % i == 0)
                    return false;
            return true;
        }

        public static bool operator false(Prime p)
        {
            for (uint i = 2; i <= p.x / 2; i++)
                if (p.x % i == 0)
                    return true;
            return false;
        }
    }
}
