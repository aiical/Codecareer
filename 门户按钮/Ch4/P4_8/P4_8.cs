using System;

namespace P4_8
{
    class Program
    {
        static void Main()
        {
            ComplexNumber c1 = ComplexNumber.Parse("(50+100i)");
            ComplexNumber c2;
            ComplexNumber.TryParse("(100,300i)", out c2);
            Console.WriteLine("{0} + {1} = {2}", c1, c2, c1 + c2);
            ComplexNumber.TryParse("(100+300i)", out c2);
            Console.WriteLine("{0} + {1} = {2}", c1, c2, c1 + c2);
            Console.ReadLine();
        }
    }

    public class ComplexNumber
    {
        public double A = 0, B = 0;

        public ComplexNumber(double a, double b)
        {
            A = a;
            B = b;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.A + c2.A, c1.B + c2.B);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.A - c2.A, c1.B - c2.B);
        }

        public static ComplexNumber Parse(string s)
        {
            if (s == null)
                throw new ArgumentNullException();
            s = s.ToUpper();
            int pos1 = s.IndexOf('+');
            int pos2 = s.IndexOf('I');
            if (pos1 == -1 || pos2 == -1)
                throw new FormatException("输入的字符串格式不正确");
            double a = double.Parse(s.Substring(1, pos1 - 1));
            double b = double.Parse(s.Substring(pos1 + 1, pos2 - pos1 - 1));
            return new ComplexNumber(a, b);
        }

        public static bool TryParse(string s, out ComplexNumber c)
        {
            c = new ComplexNumber(0, 0);
            if (s == null)
                return false;
            s = s.ToUpper();
            int pos1 = s.IndexOf('+');
            int pos2 = s.IndexOf('I');
            if (pos1 == -1 || pos2 == -1)
                return false;
            string s1 = s.Substring(1, pos1 - 1);
            string s2 = s.Substring(pos1 + 1, pos2 - pos1 - 1);
            if (pos1 == -1 || pos2 == -1 || !double.TryParse(s1, out c.A) || !double.TryParse(s2, out c.B))
                return false;
            else
                return true;
        }

        public override string ToString()
        {
            return String.Format("({0}+{1}i)", this.A, this.B);
        }
    }
}
