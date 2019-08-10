using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PhoneBook
    {
        private Node<Contact> first;
        public PhoneBook()
        {
            this.first = null;
        }

        public void Add(String name, String phone)
        {
            Node<Contact> temp = new Node<Contact>(new Contact(name, phone));
            if(this.first==null)
            {
                this.first = temp;
            }
            if(name.CompareTo(this.first.GetValue().GetName())<0)
            {
                temp.SetNext(this.first);
                this.first = temp;
            }

            Node<Contact> pos = this.first;
            while(pos.GetNext()!=null)
            {
                if(name.CompareTo(pos.GetNext().GetValue().GetName())<0)
                {
                    temp.SetNext(pos.GetNext());
                    pos.SetNext(temp);
                }
                pos = pos.GetNext();
            }
            if(pos.GetNext()==null)
            {
                pos.SetNext(temp);
            }
        }

        public void DelContact(String name)
        {
            if(this.first!=null)
            {
                if(this.first.GetValue().GetName()== name)
                {
                    this.first = this.first.GetNext();
                }
                Node<Contact> pos = this.first;
                while(pos.GetNext()!=null)
                {
                    if(pos.GetNext().GetValue().GetName()==name)
                    {
                        pos.SetNext(pos.GetNext().GetNext());
                    }
                    pos = pos.GetNext();
                }
            }
        }

        public String GetPhone(String name)
        {
            Node<Contact> pos = this.first;
            while(pos!=null)
            {
                if(pos.GetValue().GetName()== name)
                {
                    return pos.GetValue().GetPhone();
                }
            }
            return null;
        }

        public String[] GetAllContactsNames()
        {
            //count the size
            int count = 0;
            Node<Contact> pos = this.first;
            while(pos!=null)
            {
                count++;
                pos = pos.GetNext();
            }
            String[] names = new String[count];
            pos = this.first;
            for(int i =0;i<names.Length;i++)
            {
                names[i] = pos.GetValue().GetName();
                pos = pos.GetNext();
            }
            return names;
        }

        public override string ToString()
        {
            String s = "";
            Node<Contact> pos = this.first;
            while(pos!=null)
            {
                s += pos.ToString() + "\n";
                pos = pos.GetNext();
            }
            return s;
        }
    }
}
