using System;
using System.Collections;
using System.Collections.Generic;

namespace P12_3
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
            Console.WriteLine("默认遍历:");
            foreach (string s in phones)
                Console.WriteLine(s);
            Console.WriteLine("\n非默认遍历:");
            foreach (string s in phones.BreakingEnumerator())
                Console.WriteLine(s);
            Console.WriteLine("\n反向遍历:");
            foreach (string s in phones.ReverseEnumerator())
                Console.WriteLine(s);
            Console.ReadLine();
        }
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
            for (int i = 0; i < 5; i++)
            {
                if (phones[i] != null)
                {
                    Console.Write((PhoneType)i);
                    yield return phones[i];
                }
            }
        }

        public IEnumerable<string> BreakingEnumerator()
        {
            for (int i = 0; i < 5; i++)
            {
                if (phones[i] != null)
                {
                    Console.Write((PhoneType)i);
                    yield return phones[i];
                }
                else
                    yield break;
            }
        }

        public IEnumerable<string> ReverseEnumerator()
        {
            for (int i = 4; i >= 0; i--)
            {
                if (phones[i] != null)
                {
                    Console.Write((PhoneType)i);
                    yield return phones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
