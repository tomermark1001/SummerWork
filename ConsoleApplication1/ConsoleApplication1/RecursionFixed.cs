using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class RecursionFixed
    {
        public static void Maze(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)//הכניסה
            {
                if (mat[i, 0] == 1)
                    Maze(mat, i, 0);
            }
        }

        public static void Maze(int[,] mat, int i, int j)
        {
            if (j < mat.GetLength(1) && j >= 0 && i < mat.GetLength(0) && i >= 0)// בדיקה שלא חרגתי מהמערך
            {
                if (mat[i, j] == 1)
                {
                    Console.WriteLine(i + "," + j);
                    Maze(mat, i + 1, j);
                    Maze(mat, i - 1, j);
                    Maze(mat, i, j + 1);
                    Maze(mat, i, j - 1);
                }
            }
        }
    }
}
