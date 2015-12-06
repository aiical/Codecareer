using System;
using P11_2;

namespace P11_5
{
    public class BiLinkNode<T> : LinkNode<T>
    {
        protected BiLinkNode<T> previous;
        protected new BiLinkNode<T> next;

        public BiLinkNode<T> Previous // 获取或设置节点的前一个节点
        {
            get { return previous; }
            set 
            {
                previous = value;
                if (previous != null && previous.Next != this)
                    previous.Next = this;
            }
        }

        public new BiLinkNode<T> Next // 获取或设置节点的下一个节点
        {
            get { return next; }
            set 
            {
                next = value;
                if (next != null && next.Next != this)
                    next.previous = this;
            }
        }

        public BiLinkNode(T t) : base(t) { }

        public static BiLinkNode<T> operator <<(BiLinkNode<T> node, int n) //移至node的第n个前驱节点
        {
            BiLinkNode<T> node1 = node;
            for (int i = 0; i < n && node1 != null; i++)
                node1 = node1.previous;
            return node1;
        }        
    }
}
