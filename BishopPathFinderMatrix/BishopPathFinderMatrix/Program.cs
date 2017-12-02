using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BishopPathFinderMatrix
{
    class Program
    {
        static int[] rows = { -1, -1, 1, 1 };
        static int[] cols = { -1, 1, 1, -1 };
        static int GetMoveDirection(string dir)
        {
            switch (dir)
            {
                case "LU":
                    return 0;
                case "UL":
                    return 0;
                case "RU":
                    return 1;
                case "UR":
                    return 1;
                case "DR":
                    return 2;
                case "RD":
                    return 2;
                case "DL":
                    return 3;
                case "LD":
                    return 3;

                default:
                    throw new ArgumentException();
                    break;
            }

        }
        static void Main(string[] args)
        {
            int[] arrNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowsCount = arrNum[0];
            int colsCount = arrNum[1];
            var matrix = new int[rowsCount, colsCount];
            int sum = 0;
            for (int i = rowsCount - 1; i >= 0; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    matrix[i, j] = (rowsCount - 1 - i) * 3 + j * 3;
                }
            }
            int movesCount = int.Parse(Console.ReadLine());
            int row = rowsCount - 1;
            int col = 0;
            for (int i = 0; i < movesCount; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var dir = input[0];
                var repeat = int.Parse(input[i]);
                
                var moveDir = GetMoveDirection(dir);

                for (int j = 0; j < repeat-1; j++)
                {
                    row += rows[moveDir];
                    col += cols[moveDir];
                    if (row > rowsCount-1|| row < 0|| col >colsCount-1||col<0)
                    {
                        row -= rows[moveDir];
                        col -= cols[moveDir];
                        break;
                    }
                    else
                    {
                        sum += matrix[row, col];
                        matrix[row, col]=0;
                    }

                }
            }
            Console.WriteLine(sum);
            PrintMatrix(matrix);

        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i,j]+" ");
                }
               
            }


}
    }
}
