using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Recursion
    {
        //טענת כניסה: הפעולה מקבלת מטריצה המייצגת מבוך שלו כניסה אחת ויציאה אחת. מעבר מייצג 1ת אין מעבר מייצג 0
        // טענת יציאה: הפעולה מדפיסה את המסלול ליציאה מהמבוך

        public static void Maze(int[,] mat)
    {
            Maze(mat, 0, 0);
    }
        //הפעולה מקבלת מטריצה והתחלה
        private static void Maze(int[,] mat, int i , int j)
        {
            if(j!=mat.GetLength(1))//הפעולה תיגמר כאשר הגענו לסוף השורה האחרונה
            {
                if(mat[i,j]==1)//במקרה כשזו הדרך
                {
                    Console.WriteLine(i+","+j);
                    Maze(mat, 0, j + 1);
                }
                Maze(mat, i + 1, j);//במקרה וזו לא הדרך. אין טעם לבדוק תקינות בשורה, משום שמניחים כי יש דרך כלשהי
            }
        }
}
}
