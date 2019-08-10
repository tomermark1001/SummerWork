using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Efficiency
    {
        //כתבו פעולה המקבלת שני מספרים ומוצאת את המחלק הגדול ביותר של שניהם. נתחו את יעילות הפעולה שכתבתם
        public static int BiggestDivider(int x1, int x2)
        {
             if(x2==0)
            {
                return x1;
            }
            return BiggestDivider(x2, x1 % x2);
        }
        //יעילות הפעולה היא O(

        
    }
}
