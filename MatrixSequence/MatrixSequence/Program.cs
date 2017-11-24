using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string  sizes = Console.ReadLine();
            int rows = int.Parse(sizes.Split()[0]);
            int cols = int.Parse(sizes.Split()[1]);
            var matrix = new string[rows,cols];
            //filling the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                 string [] shano =Console.ReadLine().Split().ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = shano[j];
                }
            }
            int sequence = 0;
            int MaxSequence = 0;
            int SideMax = 0;
            int dMax = 0;
            int d2Max = 0;
            // //sequences Down&Up
            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                sequence = 1;
                for (int row = 1; row < matrix.GetLength(0); row++)
                {

                    if (matrix[row, col].Equals(matrix[row - 1, col]))
                    {
                        sequence++;

                    }
                }
                if (MaxSequence < sequence)
                {
                    MaxSequence = sequence;
                }
            }
            // Console.WriteLine(MaxSequence);
            // sequence Right&Left
            for (int sideRow = 0; sideRow < matrix.GetLength(0); sideRow++)
            {

                sequence = 1;
                for (int sideCol = 1; sideCol < matrix.GetLength(1); sideCol++)
                {
                    if (matrix[sideRow, sideCol].Equals(matrix[sideRow, sideCol - 1]))
                    {
                        sequence++;
                    }
                }
                if (SideMax < sequence)
                {
                    SideMax = sequence;
                }

            }
            // Console.WriteLine(SideMax);
            //DIAGONALITE DO SREDA 
            for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
           {
                sequence = 1;
                
              for (int secRow = row, col = 0; secRow < matrix.GetLength(1)-2; secRow++, col++)
                  {
                    if (matrix[secRow+1,col+1]==matrix[secRow,col])
                    {
                        sequence++;
                    }

                  }
                if (dMax<sequence)
                {
                    dMax =  sequence+2;
                }
           }
            //Console.WriteLine(dMax);
            //DIAGONALI OT SREDA
            for (int col = 1; col < matrix.GetLength(1)+2; col++)
            {
                for (int secCol = col, row = 0; secCol < matrix.GetLength(0)-2; secCol++ , row++)
                {
                    if (matrix[row, secCol] == matrix[row + 1, secCol + 1])
                    {
                        sequence++;
                    }
                    

                }
                if (d2Max<sequence)
                {
                    d2Max = sequence;
                }
            }
            Console.WriteLine(d2Max);
        }
       }
    }

