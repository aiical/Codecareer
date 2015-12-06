using System;
using P9_6;

namespace P9_7
{
    class Program
    {
        static void Main()
        {
            try
            {
                NumberSequence ns1 = new NumberSequence(1, delegate(int a) { return a + 3; });
                Console.Write("数列ns1前10项为: ");
                foreach (int i in ns1.GetNumbers(10))
                {
                    Console.Write(i);
                    Console.Write(' ');
                }
                NumberSequence ns2 = new IncrementalNumberSequence(1, delegate(int a) { return a + 3; });
                Console.Write("\n数列ns2前10项为: ");
                foreach (int i in ns2.GetNumbers(10))
                {
                    Console.Write(i);
                    Console.Write(' ');
                }
                NumberSequence ns3 = new DecrementalNumberSequence(1, delegate(int a) { return a + 3; });
                Console.Write("\n数列ns3前10项为: ");
                foreach (int i in ns3.GetNumbers(10))
                {
                    Console.Write(i);
                    Console.Write(' ');
                }
            }
            catch (NumberSequenceException exp)
            {
                Console.WriteLine("发生数列异常: {0}", exp.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine("发生异常: {0}", exp.Message);
            }
            Console.ReadLine();
        }
    }

    public class IncrementalNumberSequence : NumberSequence
    {
        public IncrementalNumberSequence(int a0, Recur recur) : base(a0, recur) { }

        public override int GetNumber(int n)
        {
            int a = _a0;
            for (int i = 1, b; i < n; i++)
            {
                b = _recur(a);
                if (b < a)
                    throw new NumberSequenceException("数列项非递增", i);
                a = b;
            }
            return a;
        }

        public override int[] GetNumbers(int n)
        {
            int[] numbers = new int[n];
            numbers[0] = _a0;
            for (int i = 1; i < n; i++)
            {
                numbers[i] = _recur(numbers[i - 1]);
                if (numbers[i] < numbers[i - 1])
                    throw new NumberSequenceException("数列项非递增", i);
            }
            return numbers;
        }
    }

    public class DecrementalNumberSequence : NumberSequence
    {
        public DecrementalNumberSequence(int a0, Recur recur) : base(a0, recur) { }

        public override int GetNumber(int n)
        {
            int a = _a0;
            for (int i = 1, b; i < n; i++)
            {
                b = _recur(a);
                if (b > a)
                    throw new NumberSequenceException("数列项非递减", i);
                a = b;
            }
            return a;
        }

        public override int[] GetNumbers(int n)
        {
            int[] numbers = new int[n];
            numbers[0] = _a0;
            for (int i = 1; i < n; i++)
            {
                numbers[i] = _recur(numbers[i - 1]);
                if (numbers[i] > numbers[i - 1])
                    throw new NumberSequenceException("数列项非递减", i);
            }
            return numbers;
        }
    }
}
