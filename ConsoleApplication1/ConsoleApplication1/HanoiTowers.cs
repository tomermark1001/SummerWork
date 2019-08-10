using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HanoiTowers
    {
        private Stack<int>[] poles;
        public  const int NUMOFPOLES= 3;

        public HanoiTowers(int numOfDisscs)
        {
            if (numOfDisscs > 10 || numOfDisscs<3)
            {
                numOfDisscs = 3;
            }
            this.poles = new Stack<int>[NUMOFPOLES];
            for(int i =numOfDisscs ; i>=1 ; i--)
            {
                this.poles[1].Push(i);
            }
        }

        public bool MoveDisc(int fromPole, int toPole)
        {
            if(this.poles[fromPole].Top()<this.poles[toPole].Top())
            {
                this.poles[toPole].Push(this.poles[fromPole].Pop());
                return true;
            }
            return false;
        }

        public int GetNumOfDiscs()// מחזיר כמות כוללת
        {
            return GetNumDiscs(this.poles[0]) + GetNumDiscs(this.poles[1]) + GetNumDiscs(this.poles[2]);
        }
        public int GetNumDiscs( int poleNum)//מקבל מספר מחזיר כמות במחסנית במספר זה
        {
            return GetNumDiscs(this.poles[poleNum]);
        }
        private int GetNumDiscs(Stack<int> stk)//מקבל מחסנית מחזיר כמות
        {
            int count = 0;
            Stack<int> temp = new Stack<int>();
            while(!stk.IsEmpty())
            {
                count++;
                temp.Push(stk.Pop());
            }
            while(!temp.IsEmpty())
            {
                stk.Push(temp.Pop());
            }
            return count;
        }

        public int GetSizeTopDisc(int poleNum)
        {
            return this.poles[poleNum].Top();
        }
        public bool IsEmpty(int poleNum)
        {
            return this.poles[poleNum].IsEmpty();
        }
        

    }
}
