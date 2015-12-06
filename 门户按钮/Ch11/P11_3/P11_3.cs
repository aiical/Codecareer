using System;

namespace P11_3
{
    class Program
    {
        static void Main()
        {
            Pair<int> p1 = new Pair<int>(0);
            p1.SetValue(5); //调用SetValue(int i)
            Console.WriteLine(p1.Left); //输出5
            Console.WriteLine(p1.Right); //输出0

            Pair<string> p2 = new Pair<string>("");
            p2.SetValue(5); //调用SetValue(int i)
            p2.SetValue("王小红"); //调用SetValue(T t)
            Console.WriteLine(p2.Left);
            Console.WriteLine(p2.Right);

            Console.ReadLine();
        }
    }

    public class Pair<T>
    {
        public int Left;
        public T Right;

        public Pair(T right)
        {
            Right = right;
        } 

        public void SetValue(int i)
        {
            Left = i;
        }

        public void SetValue(T t)
        {
            Right = t;
        }
    }
}
