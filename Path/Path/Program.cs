using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path
{
    class Program
    {
        static char[,] lab =   {
{' ', ' ', ' ', '*', ' ', ' ', ' '},
{'*', '*', ' ', '*', ' ', '*', ' '},
{' ', 'S', ' ', ' ', ' ', ' ', ' '},
{' ', '*', '*', '*', '*', '*', ' '},
{' ', ' ', ' ', ' ', ' ', ' ', 'е'},
};
        static char[] path = new char[lab.GetLength(0) * lab.GetLength(1)];
        static int pos = 0;
        static void Main(string[] args)
        {

            Solvable(lab);
        }
        public static void Solvable(char[,]maze)
        {
            int startX = -1;
            int startY = -1;
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (maze[i,j]=='S')
                    {
                        startX = i;
                        startY = j;
                    }
                }
            }
            if (startX==-1||startY==-1)
            {
                return;
            }
           
            else
            {
                FindPath(startX,startY,'S');
            }
        }
        public static void FindPath(int row, int col, char direction)
        {
            if (row < 0 || row >= lab.GetLength(0) || col < 0 || col >= lab.GetLength(1))
            {
                return;
            }
            path[pos] = direction;
            pos++;
            if (lab[row, col] == 'e')
            {
                PrintPath(path, 1, pos - 1);
            }
            if (lab[row, col] == ' ')
            {
                lab[row, col] = 's';

                FindPath(row, col - 1, 'L');
                FindPath(row - 1, col, 'U');
                FindPath(row, col + 1, 'R');
                FindPath(row + 1, col, 'D');
                lab[row, col] = ' ';

            }
            pos--;
        }
        static void PrintPath(char[] path, int startPos, int endPos)
        {
            Console.Write("Found path to the exit: ");
            for (int position = startPos; position <= endPos; position++)
            {
                Console.Write(path[pos]);
            }
            Console.WriteLine();
        }
    }
}
