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
            int MaxLength = 0;
            for (int row = 0; row <matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int sequence = 1;
                    for (int i = 1; col + i < matrix.GetLength(1); i++)//lqvo/dqsno
                    {
                        if (matrix[row, col] == matrix[row, col + i])
                        {
                            sequence++;
                        }
                        else
                        {
                            break;
                        }


                    }
                    if (MaxLength < sequence)
                    {
                        MaxLength = sequence;
                        sequence = 1;
                    }

                    for (int i = 1; row + i < matrix.GetLength(0); i++)//gore/dolu
                    {
                        if (matrix[row, col] == matrix[row + i, col])
                        {
                            sequence++;
                        }
                        else
                        {
                            break;
                        }

                      

                    }
                    if (MaxLength < sequence)
                    {
                        MaxLength = sequence;
                        sequence = 1;
                    }
                    for (int i = 1; row + i < matrix.GetLength(0) && cols + 1 < matrix.GetLength(1); i++)//lqvo-dqsno-diagonal
                    {
                        if (matrix[row, col] == matrix[row + i, col + i])
                        {
                            sequence++;
                        }
                        else
                        {
                            break;
                        }
                      

                    }
                    if (MaxLength < sequence)
                    {
                        MaxLength = sequence;
                        sequence = 1;
                    }
                    for (int i = 1; row + i < matrix.GetLength(0) && col - 1 >= 0; i++)//dqsno-lqvo-diagonal
                    {
                        if (matrix[row, col] == matrix[row + i, col - i])
                        {
                            sequence++;
                        }
                        else
                        {
                            break;
                        }
                        

                    }
                    if (MaxLength < sequence)
                    {
                        MaxLength = sequence;
                        sequence = 1;
                    }
                }
            }
            Console.WriteLine(MaxLength);

        }


    }
}

