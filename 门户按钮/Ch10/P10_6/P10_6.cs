using System;
using System.Collections;

namespace P10_6
{
    class Program
    {
        static void Main()
        {
            Contact c1 = new Contact("王小红");
            c1.Phones[PhoneType.手机] = "1331121122";
            c1.Phones[PhoneType.小灵通] = "1234567";
            Contact c2 = new Contact("方小白");
            c2.Phones[PhoneType.家庭电话] = "88338844";
            c2.Phones[PhoneType.办公电话] = "66116622";
            c2.Phones[PhoneType.传真] = "66116623";
            ICollection iCol = c1.Phones;
            Console.WriteLine("c1电话数量为{0}", iCol.Count);
            iCol = c2.Phones;
            Console.WriteLine("c2电话数量为{0}", iCol.Count);
            c1.Print();
            c2.Print();
            Console.ReadLine();
        }
    }

    public enum PhoneType
    {
        家庭电话, 办公电话, 手机, 小灵通, 传真
    }

    public class Phones : ICollection
    {
        private string[] phones;
        private int count = 0;

        public int Count
        {
            get { return count; }
        }

        public string this[PhoneType type]
        {
            get
            {
                return phones[(int)type];
            }
            set
            {
                int index = (int)type;
                if (phones[index] == null && value != null)
                    count++;
                else if (phones[index] != null && value == null)
                    count--;
                phones[index] = value;
            }
        }

        public Phones()
        {
            phones = new string[5];
        }

        public void CopyTo(Array array, int index)
        {
            foreach (string s in phones)
                if (s != null)
                    array.SetValue(s, index++);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < 5; i++)
                if (phones[i] != null)
                    yield return string.Format("{0}: {1}", (PhoneType)i, phones[i]);
        }

        bool ICollection.IsSynchronized
        {
            get { return false; }
        }

        object ICollection.SyncRoot
        {
            get { return null; }
        }
    }

    public class Contact
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private Phones phones;
        public Phones Phones
        {
            get { return phones; }
        }

        public Contact(string name)
        {
            this.name = name;
            phones = new Phones();
        }

        public void Print()
        {
            Console.WriteLine("姓名: " + name);
            Console.WriteLine("地址: " + address);
            foreach (string s in phones)
                Console.WriteLine(s);
        }
    }
}
