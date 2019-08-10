using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class List<T>
    {
        private Node<T> first;
        public List()
        {
            this.first = null;
        }
        public bool IsEmpty()
        {
            return this.first == null;
        }
        public Node<T> GetFirst()
        {
            return this.first;
        }

        public Node<T> Insert(Node<T> pos, T x)
        {
           if(pos==null)
            {
                Node<T> temp = new Node<T>(x, this.first);
                this.first = temp;
                return this.first;
            }
            pos.SetNext(new Node<T>(x, pos.GetNext()));
            return pos.GetNext();
        }

        public Node<T> Remove(Node<T> pos)
        {
            if (pos == this.first)
            {
                this.first = this.first.GetNext();
                return this.first;
            }
            Node<T> temp = this.first;
            while (temp.GetNext() != pos)
            {
                temp = temp.GetNext();
            }
            Node<T> remove = temp.GetNext();
            temp.SetNext(temp.GetNext().GetNext());
            remove.SetNext(null);// doesnt give any sort of connection to the list
            return remove;
        }

        public override string ToString()
        {
            if (this.first == null)
                return "";
            String s = "[";
            Node<T> temp = this.first;
            while(temp!=null)
            {
                s += temp.GetValue();
                if(temp.GetNext()!=null)
                {
                    s += ",";
                }
                else
                {
                    s += "]";
                }
                temp = temp.GetNext();
            }
            return s;
        }
    }
