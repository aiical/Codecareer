using System;
using System.Collections;
using System.Collections.Generic; 

namespace P12_2
{
    class Program
    {
        static void Main()
        {
            Phones phones = new Phones();
            phones[PhoneType.手机] = "1331121122";
            phones[PhoneType.办公电话] = "66116622";
            phones[PhoneType.家庭电话] = "88338844";
            phones[PhoneType.传真] = "66116623";
            foreach (string s in phones)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }

    public class MyEnumerator<T> : IEnumerator<T>
    {
        private int current;
        internal T[] array;

        public T Current
        {
            get { return array[current]; }
        }

        object IEnumerator.Current
        {
            get { return array[current]; }
        }

        public MyEnumerator(T[] array)
        {
            this.array = array;
            this.current = -1;
        }

        public bool MoveNext()
        {
            if (++current == array.Length)
                return false;
            if (array[current] == null)
                MoveNext();
            Console.WriteLine("MoveNext");
            return true;
        }

        public void Reset()
        {
            current = -1;
        }

        void IDisposable.Dispose() { }
    }

    public enum PhoneType
    {
        家庭电话, 办公电话, 手机, 小灵通, 传真
    }

    public class Phones : IEnumerable<string>
    {
        private string[] phones;

        public string this[PhoneType type]
        {
            get { return phones[(int)type]; }
            set { phones[(int)type] = value; }
        }

        public Phones()
        {
            phones = new string[5];
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new MyEnumerator<string>(phones);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
