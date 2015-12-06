using System;

namespace P3_1
{
    class Program
    {
        static void Main()
        {
            ComplexNumber c1; //定义结构变量c1
            c1.a = 1.5;
            c1.b = 3;
            ComplexNumber c2 = c1; //定义结构变量c2
            c2.a = c2.b;
            Console.Write("c1 = ");
            c1.Write();
            Console.Write("c2 = ");
            c2.Write();
            Console.ReadLine();
        }
    }
    
    struct ComplexNumber
    {
        public double a;
        public double b;

        public void Write()
        {
            Console.WriteLine("{0}+{1}i", a, b);
        }
    }
}
