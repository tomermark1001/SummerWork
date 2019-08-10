using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Node<T>
    {
        private T value;
        private Node<T> next;
        public Node(T value)
        {
            this.value = value;
        }
        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
        public T GetValue()
        {
            return this.value;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
