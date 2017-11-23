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



        }
    }
}
