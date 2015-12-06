using System;
using System.Text;

namespace P3_3
{
    class Program
    {
        static void Main()
        {
            ComplexNumber c1 = new ComplexNumber();
            c1.a = 1.5;
            c1.b = 3;
            ComplexNumber[] cs = new ComplexNumber[4];
            cs[0] = c1;
            cs[1] = new ComplexNumber();
            cs[1].a = 4;
            cs[1].b = 5;
            cs[2] = c1;
            cs[3] = cs[1];
            cs[0].a = 8;
            cs[3].b = 9;
            Console.Write("c1 = ");
            c1.Write();
            Console.Write("cs[1] = ");
            cs[1].Write();
            Console.Write("cs[2] = ");
            cs[2].Write();
            Console.ReadLine();
        }
    }

    class ComplexNumber
    {
        public double a;
        public double b;
        public void Write()
        {
            Console.WriteLine("{0}+{1}i", a, b);
        }
    }
}
