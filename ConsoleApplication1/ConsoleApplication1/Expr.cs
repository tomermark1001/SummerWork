using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Expr
    {
        private int num1;
        private int num2;
        private char op;
        public Expr(int num1, char op, int num2)
        {
            this.num1 = num1;
            this.op = op;
            this.num2 = num2;
        }

        public int GetNum1()
        {
            return this.num1;
        }
        public int GetNum2()
        {
            return this.num2;
        }
        public char GetOp()
        {
            return this.op;
        }

        public override string ToString()
        {
            String s = "" + this.num1 + this.op + this.num2;
            return s;
        }

        public double Calculate()
        {
            if (this.op == '+')
                return (double)this.num1 + this.num2;
            if (this.op == '/')
                return (double)this.num1 / this.num2;
            if(this.op=='*')
                return (double)this.num1 * this.num2;
            return (double)this.num1 - this.num2;
        }
        
    }
}
