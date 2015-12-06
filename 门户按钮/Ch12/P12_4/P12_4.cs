using System;
using System.Collections;
using System.Collections.Generic;

namespace P12_4
{
    class Program
    {
        static void Main()
        {
            NumberSequence ns1 = new NumberSequence(1, 10, delegate(long x) { return x + 3; });
            Console.WriteLine("等差数列");
            foreach (long x in ns1)
                Console.WriteLine(x);
            NumberSequence ns2 = new NumberSequence(1, 10, delegate(long x) { return x * 3; });
            Console.WriteLine("等比数列");
            foreach (long x in ns2)
                Console.WriteLine(x);
            Console.ReadLine();
        }
    }

    public delegate long LongFunction(long x);

    public class NumberSequence : IEnumerable<long>, IEnumerator<long>
    {
        protected int length, position = 0;
        public int Position
        {
            get { return position; }
        }
        public int Length
        {
            get { return length; }
        }

        protected long first, current = 0;
        public long First
        {
            get { return first; }
            set { first = value; }
        }
        public long Current
        {
            get { return current; }
        }
        object IEnumerator.Current
        {
            get { return current; }
        }

        private LongFunction recur;

        public NumberSequence(long first, int length, LongFunction recur)
        {
            this.current = this.first = first;
            this.length = length;
            this.recur = recur;
        }

        public virtual bool MoveNext()
        {
            if (position < length)
            {
                current = recur(current);
                position++;
                return true;
            }
            return false;
        }

        public virtual void Reset()
        {
            position = 0;
            current = first;
        }

        public IEnumerator<long> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose() { }
    }
}
