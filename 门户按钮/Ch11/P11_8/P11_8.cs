using System;

namespace P11_8
{
    class Program
    {
        static void Main()
        {
            int[] a1 = { 3, 5, -2, 11, 7 };
            Console.WriteLine("数组之和为: " + CMath.Aggr(a1, (x, y) => x + y));
            Console.WriteLine("数组之积为: " + CMath.Aggr(a1, (x, y) => x * y));
            Console.WriteLine("数组的最大元素: " + CMath.Aggr(a1, Math.Max));
            double[] a2 = { -2, -0.5, 1.6, 2.5, 5 };
            Console.WriteLine("数组之和为: " + CMath.Aggr(a2, (x, y) => x + y));
            Console.WriteLine("数组之积为: " + CMath.Aggr(a2, (x, y) => x * y));
            Console.WriteLine("数组的最小元素: " + CMath.Aggr(a2, Math.Min));
            Console.ReadLine();
        }
    }

    public class CMath
    {
        public static T Max<T>(T x, T y) where T : IComparable<T>
        {
            return (x.CompareTo(y) >= 0) ? x : y;
        }

        public static T Min<T>(T x, T y) where T : IComparable<T>
        {
            return (x.CompareTo(y) <= 0) ? x : y;
        }

        public static T Aggr<T>(T[] array, Func<T, T, T> fun)
        {
            T t = array[0];
            for (int i = 1; i < array.Length; i++)
                t = fun(t, array[i]);
            return t;
        }
    }
}
