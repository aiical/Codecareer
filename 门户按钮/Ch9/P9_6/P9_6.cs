using System;

namespace P9_6
{
    public class NumberSequence
    {
        public delegate int Recur(int a);

        protected int _a0 = -1;
        public int a0
        {
            get { return _a0; }
        }

        protected Recur _recur;

        public NumberSequence(int a0, Recur recur)
        {
            _a0 = a0;
            _recur = recur;
        }

        public virtual int GetNumber(int n)
        {
            int a = _a0;
            for (int i = 1; i < n; i++)
                a = _recur(a);
            return a;
        }

        public virtual int[] GetNumbers(int n)
        {
            int[] numbers = new int[n];
            numbers[0] = _a0;
            for (int i = 1; i < n; i++)
                numbers[i] = _recur(numbers[i - 1]);
            return numbers;
        }
    }

    public class NumberSequenceException : ApplicationException
    {
        private int _item = -1;
        public int Item
        {
            get { return _item; }
        }

        public NumberSequenceException(int item)
            : base(string.Format("数列第{0}项发生异常", item))
        {
            _item = item;
        }

        public NumberSequenceException(string msg, int item)
            : base(msg)
        {
            _item = item;
        }
    }
}
