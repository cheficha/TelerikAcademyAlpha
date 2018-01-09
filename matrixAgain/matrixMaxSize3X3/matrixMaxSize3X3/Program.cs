using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixMaxSize3X3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = new int[rows,cols];
            int longestSeq = 0;
            //filling
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            //walkingThru
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int sequence = 1;
                    //right
                    for (int i = 1; col+i < matrix.GetLength(1); i++)
                    {
                        if (matrix[row,col]==matrix[row,col+i])
                        {
                            sequence++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (longestSeq<sequence)
                    {
                        longestSeq = sequence;
                        sequence = 1;
                    }
                    //down
                    for (int i = 1; row+i<matrix.GetLength(0); i++)
                    {
                        if (matrix[row,col]==matrix[row+i,col])
                        {
                            sequence++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (longestSeq<sequence)
                    {
                        longestSeq = sequence;
                        sequence = 1;
                    }
                    //diagonal dqsno
                    for (int i = 1; row+i < matrix.GetLength(0) && col+i < matrix.GetLength(1); i++)
                    {
                        if (matrix[row,col]==matrix[row+i,col+i])
                        {
                            sequence++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (longestSeq<sequence)
                    {
                        longestSeq = sequence;
                        sequence = 1;
                    }
                    //diagonal nalqvo
                    for (int i = 1; row+i < matrix.GetLength(0) && col - i >= 0; i++)
                    {
                        if (matrix[row,col]==matrix[row+i,col-i])
                        {
                            sequence++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (longestSeq<sequence)
                    {
                        longestSeq = sequence;
                        sequence = 1;
                    }
                }
            }
            Console.WriteLine(longestSeq);
        }
    }
}
