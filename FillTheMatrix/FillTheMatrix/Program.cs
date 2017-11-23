using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string letter = Console.ReadLine();
            int[,] matrix = new int[N, N];
            int buffer = 1;
            
            switch (letter)
            {
                case "a":

                    for (int i = 0; i <N; i++)
                    {
                        buffer = i+1;
                       
                        for (int j = 0; j < N; j++)
                        {
                            matrix[i, j] = buffer;
                            if (j!=N-1)
                            {
                                Console.Write(matrix[i,j]+" ");
                            }
                            else
                            {
                                Console.Write(matrix[i,j]);
                            }
                            buffer += N;
                        }                        
                        Console.WriteLine();
                        
                    }
                   
                    break;
                case "b":
                    int startValue = 1;

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
                            for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
                            {
                                matrix[j, i] = startValue++;
                            }
                        }

                        
                       
                    }

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        Console.Write(matrix[i,0]);
                        for (int j = 1; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(" "+matrix[i,j]);
                        }
                        Console.WriteLine();
                    }
                    break;
                case "c":
                    int startingPoint = 1;
                    //rows diagonal-nagore
                    for (int row = N - 1; row >= 0; row--)
                    {
                        for (int secRow = row ,col = 0;secRow< N; secRow++,col++)
                        {
                            matrix[secRow,col] = startingPoint++;
                        }
                    }
                   //cols diagonal- nadolu
                    for (int col =1; col < N; col++)
                    {
                        for (int secCol =col,row=0; secCol<N; secCol++,row++)
                        {
                            matrix[row, secCol] = startingPoint++;
                        }
                    }

                    //print
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        Console.Write(matrix[i, 0]);
                        for (int j = 1; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(" " + matrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;
                case "d":
                    int row1 = 0;
                    int col1 = 0;
                    int add = 1;
                    var isDown = true;
                    var isUp = false;
                    var isRight = false;
                    var isLeft = false;
                    while (add<=N*N)
                    {
                        matrix[row1, col1] = add;
                        if (isDown)
                        {
                            if (row1+1>=N ||matrix[row1+1,col1]!=0)
                            {
                                isDown = false;
                                isRight = true;
                                col1++;
                            }
                            else
                            {
                                row1++;
                            }
                        }
                        else if (isRight)
                        {
                            if (col1+1>=N||matrix[row1,col1+1]!=0)
                            {
                                isRight = false;
                                isUp = true;
                                row1--;
                            }
                            else
                            {
                                col1++;
                            }
                        }
                        else if (isUp)
                        {
                            if (row1-1<0||matrix[row1-1,col1]!=0)
                            {
                                isUp = false;
                                isLeft = true;
                                col1--;
                            }
                            else
                            {
                                row1--;
                            }
                        }
                        else if (isLeft)
                        {
                            if (col1-1<0||matrix[row1,col1-1]!=0)
                            {
                                isLeft = false;
                                isDown = true;
                                row1++;
                            }
                            else
                            {
                                col1--;
                            }
                        }

                       add++;
                    }
                  
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            Console.Write(matrix[i, 0]);
                            for (int j = 1; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(" " + matrix[i, j]);
                            }
                            Console.WriteLine();
                        }
                    


                    break;
                default:
                    break;
            }


        }
    }
}
