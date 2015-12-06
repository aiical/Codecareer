﻿using System;
using System.Collections.Generic;

namespace P11_1
{
    class Program
    {
        static void Main()
        {
            int[] x1 = { 5, 9, 6, 3, -6, 12 };
            Stack<int> stack1 = new Stack<int>();
            for (int i = 0; i < x1.Length; i++)
                stack1.Push(x1[i]);
            int[] x2 = new int[x1.Length];
            for (int i = 0; i < x2.Length; i++)
                x2[i] = stack1.Pop();
            foreach (int i in x2)
                Console.WriteLine(i);
            string[] ss1 = { "one", "day", "when", "we", "were", "young" };
            Stack<string> stack2 = new Stack<string>();
            for (int i = 0; i < ss1.Length; i++)
                stack2.Push(ss1[i]);
            string[] ss2 = new string[ss1.Length];
            for (int i = 0; i < ss1.Length; i++)
                ss2[i] = stack2.Pop();
            foreach (string s in ss2)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
