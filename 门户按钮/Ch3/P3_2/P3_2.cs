using System;

namespace P3_2
{
    class Program
    {
        static void Main()
        {
            ComplexNumber c1 = new ComplexNumber(); //创建c1对象
            c1.a = 1.5;
            c1.b = 3;
            ComplexNumber c2 = c1; //创建c2对象
            c2.a = c2.b;
            Console.Write("c1 = ");
            c1.Write();
            Console.Write("c2 = ");
            c2.Write();
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
