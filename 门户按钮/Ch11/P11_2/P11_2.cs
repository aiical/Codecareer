using System;

namespace P11_2
{
    public class LinkNode<T>
    {
        protected T data;
        protected LinkNode<T> next;

        public T Data // 获取或设置节点值
        {
            get { return data; }
            set { data = value; }
        }

        public LinkNode<T> Next // 获取或设置节点的下一个节点
        {
            get { return next; }
            set { next = value; }
        }

        public LinkNode() // 创建链表节点
        {
            data = default(T);
        }

        public LinkNode(T t) // 指定数据创建链表节点
        {
            data = t;
        }

        public static LinkNode<T> operator >>(LinkNode<T> node, int n) //移至node的第n个后续节点
        {
            LinkNode<T> node1 = node;
            for (int i = 0; i < n && node1 != null; i++)
                node1 = node1.next;
            return node1;
        }
    }
}
