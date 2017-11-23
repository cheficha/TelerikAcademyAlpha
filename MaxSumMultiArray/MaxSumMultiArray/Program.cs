using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumMultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(new char[] { ' ' });
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);
            var matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] masiv = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = masiv[j];
                }
            }
            int bestSum = int.MinValue;
           
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2 ; col++)
                {
                    int sum = matrix[row , col] + matrix[row , col + 1] + matrix[row, col+2]+
                         matrix[row + 1, col] + matrix[row+1 , col+1] + matrix[row + 1, col+2]+
                          matrix[row + 2, col] + matrix[row + 2, col+1]+ matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
                
            }
         
            Console.WriteLine(bestSum);

        }
    }
}
    
