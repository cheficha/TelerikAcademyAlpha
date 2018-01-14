using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionMazeTraining
{
    class Program
    {
        static char[,] maze;
        static int StartX;
        static int StartY;
        static int x;
        static int y;
        static bool isSolveble;
        static void Main(string[] args)
        {
            x = 10;
            y = 10;
            char[,] maze = new char[x, y];
            for (int i = 0; i < 9; i++)
            {
                maze[i, 0] = '*';
            }
            for (int i = 0; i < 5; i++)
            {
                maze[0, i] = '*';
            }
            maze[2, 0] = '*';
            maze[2, 1] = 'S';
            maze[2, 2] = '*';
            maze[2, 3] = '*';
            maze[2, 4] = '*';
            maze[1, 4] = '*';
            maze[3, 4] = '*';
            maze[3, 5] = '*';
            maze[3, 6] = '*';
            maze[3, 7] = '*';
            maze[3, 8] = '*';
            maze[3, 9] = '*';
            maze[4, 9] = '*';
            maze[5, 9] = '*';
            maze[6, 9] = '*';
            maze[7, 9] = '*';
            maze[8, 9] = '*';
            maze[9, 9] = '*';
            maze[9, 8] = '*';
            maze[9, 7] = '*';
            maze[9, 6] = '*';
            maze[9, 5] = '*';
            maze[7, 5] = '*';
            maze[8, 5] = '*';
            maze[8, 4] = '*';
            maze[8, 3] = '*';
            maze[8, 2] = '*';
            maze[8, 1] = '*';
            maze[8, 0] = '*';
            maze[8, 8] = 'E';
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write(maze[i, j]);
                }
            }
            IsMatrixSolvable(maze);

        }
        public static void IsMatrixSolvable(char[,] maze)
        {
            StartX = -1;
            StartY = -1;
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (maze[i, j] == 'S')
                    {
                        StartX = i;
                        StartY = j;
                    }
                }
            }
            if (StartX == -1)
            {
                isSolveble = false;
            }
            else if (StartX > 0 && StartY > 0)
            {
                 
                exploreMaze(maze, StartX, StartY);
                isSolveble = true;
            }


        }
        public static bool exploreMaze(char[,] maze, int x, int y)
        {
            if (y > 9 || y < 0 || x < 0 || x > 9)
            {
                return false;
            }
            else if (maze[x,y]=='*')
            {
                return false;
            }
            else if (maze[x,y]=='E')
            {
                return true;
            }
            if (exploreMaze(maze,x,y-1))
            {
                return true;
            }
            if (exploreMaze(maze, x, y +1))
            {
                return true;
            }
            if (exploreMaze(maze, x-1, y)) 
            {
                return true;
            }
            if (exploreMaze(maze, x+1, y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
