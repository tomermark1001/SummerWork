using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static double SumExpressions(List<Expr> lst)// list
        {
            return SumExpressions(lst.GetFirst());
        }
        public static double SumExpressions(Node<Expr> first)
        {
            double sum = 0;
            while(first!=null)
            {
                sum += first.GetValue().Calculate();
                first = first.GetNext();
            }
            return sum;
        }
        //static void Main(string[] args)
        //{

        //}
    }
}
