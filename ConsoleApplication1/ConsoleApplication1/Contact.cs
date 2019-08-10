using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Contact
    {
        private String name;
        private String phone;

        public Contact(String name, String phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public String GetName()
        {
            return this.name;
        }
        
        public String GetPhone()
        {
            return this.phone;
        }
        public void SetPhone(String phone)
        {
            this.phone = phone;
        }
        public override string ToString()
        {
            return this.name + " , " + this.phone;
        }
    }
}
