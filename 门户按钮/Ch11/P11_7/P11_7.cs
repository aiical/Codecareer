using System;
using System.Collections;
using System.Collections.Generic;
using P11_2;

namespace P11_7
{
    class Program
    {
        static void Main()
        {
            LinkList<Appointment> l1 = new LinkList<Appointment>();
            l1.Add(new Appointment(new DateTime(2009, 1, 1), "徐海洋"));
            l1.Add(new Appointment(new DateTime(2009, 1, 3), "王亮"));
            l1.Add(new Appointment(new DateTime(2009, 1, 4), "刘静"));
            l1.Add(new Appointment(new DateTime(2009, 1, 7), "王小燕"));
            l1.Insert(2, new Appointment(new DateTime(2009, 1, 5), "成亮"));
            l1.RemoveAt(3);
            while (l1.MoveNext())
                Console.WriteLine(l1.Current);
            foreach (Appointment a in l1)
                Console.WriteLine(a);
            Console.ReadLine();
        }

        struct Appointment
        {
            public DateTime Time;
            public string Customer;

            public Appointment(DateTime time, string customer)
            {
                Time = time;
                Customer = customer;
            }

            public override string ToString()
            {
                return Time.ToLongDateString() + Customer;
            }
        }
    }

    public class LinkList<T> : ICollection<T>, IList<T>, IEnumerator<T>
    {
        protected LinkNode<T> first, last, current;
        public T Current
        {
            get { return current.Data; }
            set { current.Data = value; }
        }

        private int count = 0;
        public int Count
        {
            get { return count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public T this[int index] // 获取指定位置的节点值
        {
            get { return this.GetNode(index).Data; }
            set { this.GetNode(index).Data = value; }
        }

        public LinkList()
        {
            current = last = first = new LinkNode<T>(default(T));
        }

        public void Add(T t) //向链表尾部加入元素
        {
            last.Next = new LinkNode<T>(t);
            last = last.Next;
            count++;
        }

        public void Clear() //清空链表
        {
            current = last = first;
            first.Next = null;
        }

        public bool Contains(T t) //检查是否包含某个元素
        {
            return (this.IndexOf(t) >= 0);
        }

        public bool MoveNext() //当前位置移动到下一个元素
        {
            if (current.Next != null)
            {
                current = current.Next;
                return true;
            }
            else
                return false;
        }

        public void Reset() //将当前节点重设为头节点
        {
            current = first;
        }

        public int IndexOf(T t) //查找包含指定值的节点位置
        {
            LinkNode<T> node = first.Next;
            int i = 0;
            while (node != null)
            {
                if (node.Data.Equals(t))
                    return i;
                node = node.Next;
            }
            return -1;
        }
                
        public void Insert(int index, T t) // 在指定位置处插入节点
        {
            LinkNode<T> node = this.GetNode(index - 1);
            LinkNode<T> newNode = new LinkNode<T>(t);
            if (node.Next != null)
                newNode.Next = node.Next;
            node.Next = newNode;
            count++;
        }

        public void RemoveAt(int index) // 删除指定位置的节点
        {
            LinkNode<T> node = this.GetNode(index - 1);
            node.Next = node.Next.Next;
            count--;    
        }

        public bool Remove(T t) // 删除指定的节点
        {
            int i = this.IndexOf(t);
            if (i < 0)
                return false;
            this.RemoveAt(i);
            return true;
        }

        public void CopyTo(T[] array, int index)  //将所有节点数据复制到数组
        {
            LinkNode<T> node = first.Next;
            while (node != null && index < array.Length)
            {
                array[index++] = node.Data;
                node = node.Next;
            }
        }

        protected LinkNode<T> GetNode(int index)
        {
            LinkNode<T> node = first.Next;
            for (int i = 0; i < index; i++)
            {
                if (node == null)
                    throw new IndexOutOfRangeException("超出链表末尾");
                node = node.Next;
            }
            return node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (current.Next != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        object IEnumerator.Current
        {
            get { return current.Data; }
        }

        void IDisposable.Dispose() { }
    }
}
