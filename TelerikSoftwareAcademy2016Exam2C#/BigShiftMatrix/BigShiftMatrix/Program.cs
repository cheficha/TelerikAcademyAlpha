using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigShiftMatrix
{

    class Program
    {
        static int Rows;
        static int Cols;
        static void Main(string[] args)
        {
            Rows = int.Parse(Console.ReadLine());
            Cols = int.Parse(Console.ReadLine());
            var Moves = int.Parse(Console.ReadLine());
            var matrix = new BigInteger[Rows, Cols];
            fillTheMatrix(matrix);
            var COEF = Rows >= Cols ?
                      Rows : Cols;
            var CODES = Console.ReadLine()
               .Trim()
               .Split()
               .Select(int.Parse)
               .ToArray();
            var CurrentRow = Rows - 1;
            var CurrentCol = 0;
            BigInteger sum = 0;
            foreach (var code in CODES)
            {
                var targetRow = code / COEF;
                var targetCol = code % COEF;

                
                for (int move = Math.Min(CurrentCol, targetCol);
                         move <= Math.Max(CurrentCol, targetCol);
                         move++)
                {
                    sum += matrix[CurrentRow, move];
                    matrix[CurrentRow, move] = 0;
                }

               CurrentCol = targetCol;

               
                for (int move = Math.Min(CurrentRow, targetRow);
                         move <= Math.Max(CurrentRow, targetRow);
                         move++)
                {
                    sum += matrix[move, CurrentCol];
                    matrix[move, CurrentCol] = 0;
                }

                CurrentRow = targetRow;
            }

            Console.WriteLine(sum);
        }
    

        private static void fillTheMatrix(BigInteger[,] fill)
        {
            fill[0, 0] =(long)Math.Pow( 2 , (fill.GetLength(0) - 1));
            

            //first row
            for (int j = 1; j < fill.GetLength(1); j++)
                {
                int i = 0;
                fill[i, j] = fill[i, j - 1] * 2;
              
                }
           
            //the other rows
            for (int i = 1; i < fill.GetLength(0); i++)
            {
                fill[i, 0] = fill[i - 1, 0] / 2;
                for (int j = 1; j < fill.GetLength(1); j++)
                {
                    fill[i, j] = fill[i, j - 1] * 2;
                  
                }
              
            }
            
        }
    }
}
