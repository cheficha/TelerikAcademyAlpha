using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillMatrix
{
    class Program
    {
        static int N = int.Parse(Console.ReadLine());
        //static int M= int.Parse(Console.ReadLine());

        static int startValue = 1;
        static int[,] matrix = new int [N,N];
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            string variation = Console.ReadLine();
            HowToFill(variation);
        }

        private static void HowToFill(string variation)
        {
            switch (variation)
            {
                case "a":
                    VariationA();
                    break;
                case "b":
                    VariationB();
                    break;
                case "c":
                    VariationC();
                    break;
                case "d":
                    variationD();
                    break;
                default:
                    break;
            }
        }

        private static void variationD()
        {
            int row = 0;
            int col = 0;
            int counter = 1;
            var isDown = true;
            var isRight = false;
            var isUp = false;
            var isLeft = false;
            while (counter<=N*N)
            {
                matrix[row,col] = counter;
                if (isDown)
                {
                    if (row+1>=matrix.GetLength(0)||matrix[row+1,col]!=0)
                    {
                        isDown = false;
                        isRight = true;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
                else if (isRight)
                {
                    if (col+1>=matrix.GetLength(1)||matrix[row,col+1]!=0)
                    {
                        isRight = false;
                        isUp = true;
                        row--;
                    }
                    else
                    {
                        col++;
                    }

                }
                else if (isUp)
                {
                    if (row-1<0||matrix[row-1,col]!=0)
                    {
                        isUp = false;
                        isLeft = true;
                        col--;
                    }
                    else
                    {
                        row--;
                    }

                }
                else if (isLeft)
                {
                    if (col-1<0||matrix[row,col-1]!=0)
                    {
                        isLeft = false;
                        isDown = true;
                        row++;
                    }
                    else
                    {
                        col--;
                    }

                }
                counter++;

            }
            fillMatrix();
        }

        private static void VariationC()
        {
            //diagonal zapochvasht ot [n-1,0](nagore)
            for (int row = matrix.GetLength(0)-1; row >=0; row--)
            {
                for (int secRow = row, col = 0; secRow < matrix.GetLength(0); secRow++, col++)
                {
                    matrix[secRow, col] = startValue++;
                }
            }
            //diagonal zaopchvasht ot [0,1](nadolu)
            for (int col = 1; col <matrix.GetLength(1); col++)
            {
                for (int secCol = col,row=0; secCol<=matrix.GetLength(0)-1; secCol++,row++)
                {
                    matrix[row, secCol] = startValue++;
                }
            }
            fillMatrix();
        }

        private static void VariationB()
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                var isEven = i % 2 == 0;
                if (isEven)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        matrix[j, i] = startValue++;
                    }
                }
                else
                {
                    for (int j =matrix.GetLength(0)-1; j >=0; j--)
                    {
                        matrix[j, i] = startValue++;
                    }
                }
            }
            fillMatrix();
        }

        private static void VariationA()
        {

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[j, i] = startValue++;
                }
            }
            fillMatrix();
        }

        private static void fillMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, 0]);
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
