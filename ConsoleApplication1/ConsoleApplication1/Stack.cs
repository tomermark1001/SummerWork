﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Stack<T>
    {
        private Node<T> first;

        public Stack()
        {
            this.first = null;
        }

        public void Push( T x)
        {
            this.first = new Node<T>(x, this.first);
        }

        public T Pop()
        {
            T x = this.first.GetValue();
            this.first = this.first.GetNext();
            return x;
        }

        public T Top()
        {
            return this.first.GetValue();
        }
        public bool IsEmpty()
        {
            return this.first == null;
        }

        public override string ToString()
        {
            String str = "[";
            Node<T> pos = this.first;
            while(pos!=null)
            {
                str += pos.GetValue().ToString();
                if(pos.GetNext()!=null)
                {
                    str += " , ";
                }
                pos = pos.GetNext();
            }
            str += "]";
            return str;
        }
    }
}
